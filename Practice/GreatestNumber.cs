using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class GreatestNumber
    {
        internal void Find()
        {
            Console.WriteLine("enter four number (one after enter)...");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3 && num1 > num4) Console.WriteLine($"{num1} is greatest number.");
            else if (num2 > num1 && num2 > num3 && num2 > num4) Console.WriteLine($"{num2} is greatest number.");
            else if (num3 > num1 && num3 > num2 && num3 > num4) Console.WriteLine($"{num3} is greatest number.");
            else Console.WriteLine($"{num4} is greatest number.");
        }
    }
}
