#include "kjb.h"

#include <stdio.h>
#include <stdlib.h>

int main(int argc, char** argv)
{
    int ret = ERR_OK;

    const char *cnt_path = "./images/test";
    const char *res_path = "./images/test_with_message.bmp";

    const unsigned char msg[] = { 'H', 'e', 'l', 'l', 'o', '!' };
    const unsigned int msg_bits = sizeof(msg) * 8;

    const unsigned int seed = rand();

    const unsigned int red = 10;
    const float rob = .5f;
    const float den = 1.f;

    ret = kjb_insert(cnt_path, res_path, msg, msg_bits, seed, red, rob, den);
    if (ret != ERR_OK)
    {
        printf("Insert error: %d\n", ret);
        return ret;
    }

    unsigned char buf[msg_bits];
    const unsigned int buf_bits = sizeof(buf) * 8;

    const unsigned int nbh = 2;

    ret = kjb_extract(res_path, buf, buf_bits, seed, red, nbh, den);
    if (ret != ERR_OK)
    {
        printf("Extract error: %d\n", ret);
        return ret;
    }

    printf("Original message:\n[");
    for (size_t i = 0; i < msg_bits / 8; ++i)
    {
        printf("%c", (char)msg[i]);
    }
    printf("]\n");

    printf("Extracted message:\n[");
    for (size_t i = 0; i < msg_bits / 8; ++i)
    {
        printf("%c", (char)buf[i]);
    }
    printf("]\n");

    printf("Original message (binary):\n[");
    for (size_t i = 0; i < msg_bits; ++i)
    {
        printf("%d", ((msg[i / 8] & (1 << (i % 8))) != 0));
    }
    printf("]\n");

    printf("Extracted message (binary):\n[");
    for (size_t i = 0; i < msg_bits; ++i)
    {
        printf("%d", ((buf[i / 8] & (1 << (i % 8))) != 0));
    }
    printf("]\n");

    return ERR_OK;
}
