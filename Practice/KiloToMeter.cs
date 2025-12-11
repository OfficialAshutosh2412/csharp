using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class KiloToMeter
    {
        internal double m = 0,km = 2;
        internal void CalKmtoM()
        {
            m = km * 1000;
            Console.WriteLine("{0}km = {1}m", km, m);

        }
    }
}
