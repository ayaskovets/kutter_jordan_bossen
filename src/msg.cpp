#include "msg.h"

Message::Message(const byte_t* _data, size_t _bits)
: buffer(_data, _data + _bits / 8 + (_bits % 8 != 0))
, cutoff(_bits)
{}

Message::Message(const char* _data, size_t _bits)
: Message((const byte_t*)_data, _bits)
{}

size_t Message::bytes() const
{ return buffer.size(); }
size_t Message::bits() const
{ return cutoff; }

byte_t Message::byte(size_t i) const
{ return buffer.at(i); }
bool Message::bit(size_t i) const
{
    const byte_t byte_value = buffer.at(i / 8);
    return byte_value & (1 << (i % 8));
}

const byte_t* Message::data() const
{ return buffer.data(); }