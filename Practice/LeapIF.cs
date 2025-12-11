using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class LeapIF
    {
        internal void check()
        {
            Console.Write("enter the year to check : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine($"year {year} is : leap year");
            }
            else
            {
                Console.WriteLine($"year {year} is : not leap year");
            }
        }
    }
}
