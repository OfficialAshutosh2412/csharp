using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SimpleInterest
    {
        int si, p;
        const int r=12, t=2;
        internal void SI()
        {
            Console.WriteLine("enter principle amount...");
            p = Convert.ToInt32(Console.ReadLine());
            si = (p * r * t) / 100;
            Console.WriteLine($"Simple Interest is : {si}");
        }
    }
}
