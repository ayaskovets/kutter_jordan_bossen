/*
 * Copyright (c) 2019-present, Andrei Yaskovets
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

#include "img.hpp"

#include <algorithm>

#define STB_IMAGE_STATIC
#define STB_IMAGE_IMPLEMENTATION
#include "stb_image.h"

#define STB_IMAGE_WRITE_STATIC
#define STB_IMAGE_WRITE_IMPLEMENTATION
#include "stb_image_write.h"

Image::Image(const char* path)
{
    int w, h;
    data = stbi_load(path, &w, &h, NULL, STBI_rgb);

    if (!data)
    {
        throw "Image path is invalid";
    }

    width = static_cast<size_t>(w);
    height = static_cast<size_t>(h);
}

Image::~Image()
{
    stbi_image_free(data);
    data = nullptr;
}

size_t Image::getWidth() const
{
    return width;
}

size_t Image::getHeight() const
{
    return height;
}

size_t Image::getCapacity() const
{
    return width * height;
}

RGBPixel Image::pixel(size_t i, size_t j) const
{
    assert(i < height && j < width && "Pixel indices are invalid");

    byte_t* ptr = data + (i * width + j) * 3;
    return RGBPixel(ptr[0], ptr[1], ptr[2]);
}

RGBPixel Image::pixel(size_t n) const
{
    assert(n < height * width && "Pixel index is invalid");

    byte_t* ptr = data + n * 3;
    return RGBPixel(ptr[0], ptr[1], ptr[2]);
}

int Image::writeBMP(const char* path)
{
    return stbi_write_bmp(path, width, height, 3, data);
}
