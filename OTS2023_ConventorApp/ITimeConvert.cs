using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTS2023_ConventorApp
{
    internal interface ITimeConvert
    {
        double ConvertHours (double hours);
        double ConvertMinutes (double minutes);
        double ConvertSeconds (double seconds);
    }
}
