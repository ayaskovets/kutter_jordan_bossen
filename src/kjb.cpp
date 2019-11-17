#include "kjb.h"

#include <algorithm>
#include <cstring>
#include <iostream>
#include <vector>

#include "img.h"
#include "msg.h"

namespace
{
    std::vector<size_t> get_diagonal_traversal(const Image& img)
    {
        const size_t width = img.getWidth();
        const size_t height = img.getHeight();

        std::vector<size_t> diagonal_traversal;
        diagonal_traversal.reserve(width * height);

        bool dir = false;
        for (size_t dg = 0; dg < width + height - 1; ++dg, dir = !dir)
        {
            const size_t j_min = dg < height ? 0 : dg - height + 1;
            const size_t j_max = std::min(dg + 1, width);

            for (size_t j = j_min; j < j_max; ++j)
            {
                const size_t row = dir ? dg - j : dg - j_max - j_min + 1 + j;
                const size_t col = dir ? j : j_max + j_min - 1 - j;
                diagonal_traversal.push_back(row * width + col);
            }
        }

        return diagonal_traversal;
    }

    float get_luminosity(const RGBPixel& pix)
    {
        return 0.299 * static_cast<float>(pix.r) +
               0.587 * static_cast<float>(pix.g) +
               0.114 * static_cast<float>(pix.b);
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
            { v_stripe += img.pixel(row - n, col).b; }
            if (row < height - n)
            { v_stripe += img.pixel(row + n, col).b; }
            if (col >= n)
            { h_stripe += img.pixel(row, col - n).b; }
            if (col < width - n)
            { h_stripe += img.pixel(row, col + n).b; }
        }

        return (v_stripe + h_stripe) / (4 * nbh_size);
    }

    size_t get_available_rand(const std::vector<size_t> diag)
    {
        size_t rnd = 0;
        do
        { rnd = static_cast<size_t>(rand()); }
        while (diag[rnd % diag.size()] == diag.size());
        return rnd;
    }
}

void _kjb_insert(Image& img,
                 const Message& msg,
                 unsigned int redundancy,
                 float robustness,
                 float density)
{
    std::vector<size_t> diag = get_diagonal_traversal(img);
    const size_t capacity = diag.size();

    for (size_t bit = 0; bit < msg.bits(); ++bit)
    {
        for (unsigned int n = 0; n < redundancy; ++n)
        {
            const size_t rnd = get_available_rand(diag);
            const size_t idx = diag[rnd % diag.size()];
            diag[rnd % diag.size()] = diag.size();
            RGBPixel pix = img.pixel(idx);

            if (msg.bit(bit) && rnd <= RAND_MAX * density)
            { pix.b += get_luminosity(pix) * (robustness / 2); }
            else
            { pix.b -= get_luminosity(pix) * (robustness / 2); }
        }
    }
}

Message _kjb_extract(const Image& img,
                     size_t msg_bits,
                     unsigned int redundancy,
                     size_t nbh_len,
                     float density)
{
    std::vector<size_t> diag = get_diagonal_traversal(img);
    const size_t capacity = diag.size();

    std::vector<byte_t> buffer(msg_bits / 8 + (msg_bits % 8 != 0));

    for (size_t bit = 0; bit < msg_bits; ++bit)
    {
        unsigned int bit_val_sum = 0;
        for (unsigned int n = 0; n < redundancy; ++n)
        {
            const size_t rnd = get_available_rand(diag);
            const size_t idx = diag[rnd % diag.size()];
            diag[rnd % diag.size()] = diag.size();
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
    { return ERR_OK; }

    if (density > 1.f || density < 0.f)
    { return ERR_INVALID_DENSITY; }

    try
    {
        Image container(container_path);
        if (msg_bits * redundancy > container.getCapacity())
        { return ERR_MSG_TOO_LARGE; }

        const Message msg(msg_ptr, msg_bits);

        srand(seed);
        _kjb_insert(container, msg, redundancy, robustness, density);

        if (container.writeBMP(result_path))
        { return ERR_OK; }
        else
        { return ERR_IMAGE_WRITE; }
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
    { return ERR_OK; }

    if (density > 1.f || density < 0.f)
    { return ERR_INVALID_DENSITY; }

    try
    {
        const Image img(img_path);
        if (msg_bits * redundancy > img.getCapacity())
        { return ERR_MSG_TOO_LARGE; }

        if (nbh_len > std::min(img.getWidth(), img.getHeight()) / 2)
        { return ERR_NEIGHBOURHOOD_TOO_LARGE; }

        srand(seed);
        Message msg = _kjb_extract(img, msg_bits, redundancy, nbh_len, density);
        std::memcpy(msg_buffer, msg.data(), msg.bytes());
    }
    catch (const char* ex)
    {
        return ERR_IMAGE_OPEN;
    }

    return ERR_OK;
}
