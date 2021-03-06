﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Task03
{

    class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y) : base(x, y)
        { }

        public override int GetHashCode()
        {
            return Tuple.Create(x, y).GetHashCode(); 
        }
    }
}