#pragma once

#include "img.h"
#include "msg.h"

enum
{
    ERR_OK = 0,

    ERR_IMAGE_OPEN = 1,
    ERR_IMAGE_WRITE = 2,
    ERR_MSG_TOO_LARGE = 3,
    ERR_NEIGHBOURHOOD_TOO_LARGE = 4
};

#ifdef _WIN32

extern "C"
{

/**
 * Encode the provided message into an image
 * 
 * @param container_path A path to a container image
 * @param result_path A path where to write the result
 * @param msg_ptr A pointer to the message buffer
 * @param msg_bits Number of bits of message to encode
 * @param seed A seed for a pseudo-random number generator. Acts like a key
 * @param robustness Parameter that sets the robustness of the encoded message.
 *                   Keep between 0 (less robust) and 1 (more robust). The
 *                   greater its value the more 'visible' the encoded data
 */

__declspec(dllexport)
int __cdecl
kjb_insert(const char* container_path,
           const char* result_path,
           const unsigned char* msg_ptr,
           unsigned int msg_bits,
           unsigned int seed,
           float robustness);

/**
 * Decode a number of bits from the provided image
 * 
 * @param img_path A path to the image with a message encoded into it
 * @param msg_buffer A buffer where to write the message decoded from the image.
 *                   Should have enough memory accesible for 'msg_bits' bits
 * @param msg_bits How many bits to extract from the image
 * @param seed A seed for a pseudo-random number generator. Acts like a key
 * @param nbh_size Size of a pixel neighbourhood area that is used for
 *                 computing the predicted blue color value. Keep in 1-3 range
 */

__declspec(dllexport)
int __cdecl
kjb_extract(const char* img_path,
            unsigned char* msg_buffer,
            unsigned int msg_bits,
            unsigned int seed,
            unsigned int nbh_size);

}

#else

int kjb_insert(const char* container_path,
               const char* result_path,
               const unsigned char* msg_ptr,
               unsigned int msg_bits,
               unsigned int seed,
               float robustness);

int kjb_extract(const char* img_path,
                unsigned char* msg_buffer,
                unsigned int msg_bits,
                unsigned int seed,
                unsigned int nbh_size);

#endif
