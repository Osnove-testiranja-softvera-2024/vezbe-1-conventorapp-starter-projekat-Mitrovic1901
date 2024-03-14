﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    public class Length : IConvert
    {
        public double Convert(double value)
        {
            return Math.Round(value * 0.305, 3);
        }
    }
}