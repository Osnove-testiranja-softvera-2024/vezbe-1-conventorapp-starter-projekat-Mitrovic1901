using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    internal class Time : ITimeConvert
    {
        public double ConvertHours(double days)
        {
            return days * 24;
        }

        public double ConvertMinutes(double days)
        {
            return days * 60 * 24;
        }

        public double ConvertSeconds(double days)
        {

            double n = 1;
            for(int i = 0;  i < 2; i++) { 
                n *= 60;
            }
            return n * 24 * days;
        }
    }
}
