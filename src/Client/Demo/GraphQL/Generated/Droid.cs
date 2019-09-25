﻿using System;
using System.Collections;
using System.Collections.Generic;
using StrawberryShake;

namespace StrawberryShake.Client
{
    public class Droid
        : IDroid
    {
        public double? Height { get; set; }

        public string Name { get; set; }

        public IFriend Friends { get; set; }
    }
}
