#pragma once

#include <vector>

using byte_t = unsigned char;

class Message
{
public:
    Message(const byte_t* _data, size_t _bits);
    Message(const char* _data, size_t _bits);

    size_t bytes() const;
    size_t bits() const;

    byte_t byte(size_t i) const;
    bool bit(size_t i) const;

    const byte_t* data() const;

private:
    std::vector<byte_t> buffer;
    size_t cutoff;
};
