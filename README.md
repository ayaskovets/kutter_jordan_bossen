# Kutter-Jordan-Bossen algorithm

This repository contains the C++ implementation of the Kutter-Jordan-Bossen stenographic algorithm. See the [original paper](https://ieeexplore.ieee.org/document/7910651) for detailed info on the algorithm

## Prerequisites

- [stb_image.h](3rd_party/stb_image.h) & [stb_image_write.h](stb_image_write.h) public domain headers included to the [3rd_party](3rd_party) directory

## Build

Mac OS X Makefile is provided for building dynamic library version of the project. Dynamic .dylib can be built via `make` in the project root directory

## Example

See the example of calls to the non mangled library API functions in the [test.cpp](test/test.cpp) file
