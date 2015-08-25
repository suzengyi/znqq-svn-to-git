﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZNQQ
{
    public class SP0x00582013
    {
        public byte[] bytes = 
        {
             0x02,0x30,0x37,0x00,0x58,0x33,0xB9,
             0x07,0x43,0x53,0xA3,0x02,0x00,0x00,0x00,0x01,
             0x01,0x01,0x00,0x00,0x65,0xB1,
             0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
             0x00,0x00,0x00,0x00,0x00,0x00,0x00,0x00,
             0x03
        };
        byte[] data;
        public SP0x00582013()
        { }
        public void PrepareData(byte[] sessionKey,string QQ)
        {
            data = Encoding.UTF8.GetBytes(QQ);
            Array.Copy(Tools.QQtoBytes(QQ),0,bytes,7,4);
            Array.Copy(new QQCrypt().QQ_Encrypt(data, sessionKey), 0, bytes, 22, 24);
        }
    }
}