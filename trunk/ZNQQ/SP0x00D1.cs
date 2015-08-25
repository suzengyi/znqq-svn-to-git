﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZNQQ
{
    public class SP0x00D1
    {
        public byte[] bytes =  
        {
             0x02
            ,0x30,0x13
            ,0x00,0xD1
            ,0x44,0x7B
            ,0x69,0xC7,0x56,0xE8
            ,0x02,0x00,0x00,0x00,0x01
            ,0x01,0x01,0x00,0x00,0x65,0xCA
            ,0xA6,0xDC,0xCC,0xCC,0xC0,0x7A,0x3A,0xFE,0x43,0xDD,0xC3,0x54,0xD5,0xF5,0xD8,0x69
            ,0x2D,0x3A,0x84,0x3F,0xE2,0x99,0xBE,0xE0,0x64,0xCE,0x26,0x9D,0x46,0x39,0xA8,0x7B
            ,0x03

        };
        byte[] data = { 0x0E, 0x03, 0x04, 0x06, 0x07, 0x08, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F, 0x10, 0x24, 0x26 };
        public SP0x00D1()
        { }
        public void PrepareData(byte[] sessionKey)
        {
            Array.Copy(new QQCrypt().QQ_Encrypt(data, sessionKey), 0, bytes, 22, 32);
        }
    }
}