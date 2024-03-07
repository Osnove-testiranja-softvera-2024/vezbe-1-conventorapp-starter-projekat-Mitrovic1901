using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    internal class Mass : IConvert
    {
        public double Convert(double value)
        {
            throw new NotImplementedException();
        }
    }
    public double Mass(double value)
    {
        double result = value / 0.284;
        return Math.Round(result, 3);
    }
   
    
    public class MassConverter : IConvert
    {
        public double Convert(double value)
        {
            return Math.Round(value / 2.205, 3);
        }
    }
}