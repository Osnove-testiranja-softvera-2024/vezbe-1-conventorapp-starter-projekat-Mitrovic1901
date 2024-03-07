using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    internal class Length : IConvert
    {
        public double Convert(double value)
        {
            throw new NotImplementedException();
        }
    }
    public double Length(double value)
    {
        double result = value * 0.304;
        return Math.Round(result,3);
    }
}
