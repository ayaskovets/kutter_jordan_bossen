#include "kjb.h"

#include <iostream>

int main(int argc, char** argv)
{
    int ret;
    const unsigned char msg[] = { 'H', 'e', 'l', 'l', 'o', ',', ' ',
                                  'w', 'o', 'r', 'l', 'd', '!' };
    const size_t msg_bits = sizeof(msg) * 8;

    ret = kjb_insert("./images/test_2.jpg",
                        "./images/test_write.bmp",
                        msg,
                        msg_bits,
                        42,
                        0.2);
    if (ret != ERR_OK)
    { std::cout << "ERROR!" << std::endl; }

    unsigned char buffer[sizeof(msg) * 8];
    ret = kjb_extract("./images/test_write.bmp",
                        buffer,
                        msg_bits,
                        42,
                        2);
    if (ret != ERR_OK)
    {
        std::cout << "ERROR!" << std::endl;
        return 1;
    }

    std::cout << "Original message: ";
    for (size_t i = 0; i < msg_bits / 8; ++i)
    { std::cout << msg[i]; }
    std::cout << std::endl;

    std::cout << "Retrieved message: ";
    for (size_t i = 0; i < msg_bits / 8; ++i)
    { std::cout << buffer[i]; }
    std::cout << std::endl;

    std::cout << "Binary original:  ";
    for (size_t i = 0; i < msg_bits; ++i)
    { std::cout << ((msg[i / 8] & (1 << (i % 8))) != 0); }
    std::cout << std::endl;

    std::cout << "Binary retrieved: ";
    for (size_t i = 0; i < msg_bits; ++i)
    { std::cout << ((buffer[i / 8] & (1 << (i % 8))) != 0); }
    std::cout << std::endl;

    return 0;
}
