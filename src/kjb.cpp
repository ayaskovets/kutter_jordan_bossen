/*
 * Copyright (c) 2019-present, Andrei Yaskovets
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

#include "kjb.h"

#include <algorithm>
#include <cstring>
#include <iostream>
#include <utility>
#include <unordered_set>
#include <vector>

#include "img.hpp"
#include "msg.hpp"

namespace
{
    float get_luminosity(const RGBPixel& pix)
    {
        return 0.299f * static_cast<float>(pix.r) +
               0.587f * static_cast<float>(pix.g) +
               0.114f * static_cast<float>(pix.b);
    }

    byte_t get_expected_blue(const Image& img,
                             size_t idx,
                             size_t nbh_size)
    {
        const size_t width = img.getWidth();
        const size_t height = img.getHeight();

        const size_t row = idx / width;
        const size_t col = idx % height;

        unsigned int v_stripe = 0;
        unsigned int h_stripe = 0;

        for (size_t n = 1; n <= nbh_size; ++n)
        {
            if (row >= n)
            {
                v_stripe += img.pixel(row - n, col).b;
            }
            if (row < height - n)
            {
                v_stripe += img.pixel(row + n, col).b;
            }
            if (col >= n)
            {
                h_stripe += img.pixel(row, col - n).b;
            }
            if (col < width - n)
            {
                h_stripe += img.pixel(row, col + n).b;
            }
        }

        return (v_stripe + h_stripe) / (4 * nbh_size);
    }
}

void _kjb_insert(Image& img,
                 const Message& msg,
                 unsigned int redundancy,
                 float robustness,
                 float density)
{
    for (size_t bit = 0; bit < msg.bits(); ++bit)
    {
        for (unsigned int n = 0; n < redundancy; ++n)
        {
            const size_t rnd = rand();
            if (rnd <= RAND_MAX * density)
            {
                RGBPixel pix = img.pixel(rnd % img.getCapacity());
                if (msg.bit(bit))
                {
                    pix.b += get_luminosity(pix) * robustness;
                }
                else
                {
                    pix.b -= get_luminosity(pix) * robustness;
                }
            }
        }
    }
}

Message _kjb_extract(const Image& img,
                     size_t msg_bits,
                     unsigned int redundancy,
                     size_t nbh_len,
                     float density)
{
    std::vector<byte_t> buffer(msg_bits / 8 + (msg_bits % 8 != 0));

    for (size_t bit = 0; bit < msg_bits; ++bit)
    {
        unsigned int bit_val_sum = 0;
        for (unsigned int n = 0; n < redundancy; ++n)
        {
            const size_t idx = rand() % img.getCapacity();
            const RGBPixel pix = img.pixel(idx);
            const byte_t pred = get_expected_blue(img, idx, nbh_len);
            bit_val_sum += (pix.b > pred && pix.b - pred < 127) ||
                           (pix.b < pred && pred - pix.b > 127);
        }
        const bool bit_val = bit_val_sum > (redundancy / 2 * density);
        buffer[bit / 8] += bit_val << (bit % 8);
    }

    return Message(buffer.data(), msg_bits);
}

int kjb_insert(const char* container_path,
               const char* result_path,
               const unsigned char* msg_ptr,
               unsigned int msg_bits,
               unsigned int seed,
               unsigned int redundancy,
               float robustness,
               float density)
{
    if (msg_bits == 0)
    {
        return ERR_OK;
    }

    if (density > 1.f || density < 0.f)
    {
        return ERR_INVALID_DENSITY;
    }

    try
    {
        Image container(container_path);
        if (msg_bits * redundancy > container.getCapacity())
        {
            return ERR_MSG_TOO_LARGE;
        }

        const Message msg(msg_ptr, msg_bits);

        srand(seed);
        _kjb_insert(container, msg, redundancy, robustness, density);

        if (!container.writeBMP(result_path))
        {
            return ERR_IMAGE_WRITE;
        }
    }
    catch (const char* ex)
    {
        return ERR_IMAGE_OPEN;
    }

    return ERR_OK;
}

int kjb_extract(const char* img_path,
                unsigned char* msg_buffer,
                unsigned int msg_bits,
                unsigned int seed,
                unsigned int redundancy,
                unsigned int nbh_len,
                float density)
{
    if (msg_bits == 0)
    {
        return ERR_OK;
    }

    if (density > 1.f || density < 0.f)
    {
        return ERR_INVALID_DENSITY;
    }

    try
    {
        const Image img(img_path);
        if (msg_bits * redundancy > img.getCapacity())
        {
            return ERR_MSG_TOO_LARGE;
        }

        if (nbh_len > std::min(img.getWidth(), img.getHeight()) / 2)
        {
            return ERR_NEIGHBOURHOOD_TOO_LARGE;
        }

        srand(seed);
        Message msg = _kjb_extract(img, msg_bits, redundancy, nbh_len, density);
        memcpy(msg_buffer, msg.data(), msg.bytes());
    }
    catch (const char* ex)
    {
        return ERR_IMAGE_OPEN;
    }

    return ERR_OK;
}
