/*
 * Copyright (c) 2019-present, Andrei Yaskovets
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

#pragma once

#include <cstddef>

using byte_t = unsigned char;

struct RGBPixel
{
    byte_t& r;
    byte_t& g;
    byte_t& b;

    constexpr RGBPixel(byte_t& _r, byte_t& _g, byte_t& _b)
    : r(_r)
    , g(_g)
    , b(_b)
    {}
};

class Image
{
public:
    Image(const char* path);
    ~Image();

    size_t getWidth() const;
    size_t getHeight() const;
    size_t getCapacity() const;

    RGBPixel pixel(size_t i, size_t j) const;
    RGBPixel pixel(size_t n) const;

    int writeBMP(const char* path);

private:
    byte_t* data;

    size_t width;
    size_t height;
};
