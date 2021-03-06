﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZNQQ
{
    public class SP0x0134
    {
        public byte[] bytes = 
        {
            0x02,
            0x30,0x13,
            0x01,0x34,//
            0x72,0x70,
            0x69,0xC7,0x56,0xE8,
            0x02,0x00,0x00,0x00,0x01,
            0x01,0x01,0x00,0x00,0x65,0xCA,
            0x94,0x46,0x22,0x02,0x24,0x0C,0xC3,0x8B,0x1F,0xD4,0x48,0x43,0x69,0xEF,0x79,0xED,
            0xE2,0x30,0x50,0x5F,0x47,0x20,0x04,0xE4,0x66,0x9E,0xEE,0xBC,0x22,0xCE,0x23,0x90,
            0x03,0xAC,0xEB,0xD3,0xDA,0x2A,0x30,0x00,
            0x03
        };
        byte[] data = { 0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x03,0xE8,0x00,0x10,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00 };
        public SP0x0134()
        { }
        public void PrepareData(byte[] sessionKey)
        {
            Array.Copy(new QQCrypt().QQ_Encrypt(data, sessionKey), 0, bytes, 22, 40);
        }
    }
}
