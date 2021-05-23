/*
 * Copyright (c) 2019-present, Andrei Yaskovets
 *
 * This source code is licensed under the MIT license found in the
 * LICENSE file in the root directory of this source tree.
 */

#include "msg.hpp"

Message::Message(const byte_t* _data, size_t _bits)
: buffer(_data, _data + _bits / 8 + (_bits % 8 != 0))
, cutoff(_bits)
{}

Message::Message(const char* _data, size_t _bits)
: Message((const byte_t*)_data, _bits)
{}

size_t Message::bytes() const
{
    return buffer.size();
}

size_t Message::bits() const
{
    return cutoff;
}

byte_t Message::byte(size_t i) const
{
    return buffer.at(i);
}

bool Message::bit(size_t i) const
{
    return buffer.at(i / 8) & (1 << (i % 8));
}

const byte_t* Message::data() const
{
    return buffer.data();
}
