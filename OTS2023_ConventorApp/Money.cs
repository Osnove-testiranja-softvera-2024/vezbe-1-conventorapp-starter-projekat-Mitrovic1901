using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    internal class Money : IConvert
    {
        public double Convert(double value)
        {
            return value * 117;
        }
    }
}
