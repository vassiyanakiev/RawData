﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {
        public int Speed { get; set; }
        public int Power { get; set; }

        public Engine(int engineSpeed, int enginePower)
        {
            Speed = engineSpeed;
            Power = enginePower;
        }
    }
}
