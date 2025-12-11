using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class PositiveNegativeChecker
    {
        internal void check()
        {
            Console.Write("enter number to check : ");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num < 0) Console.WriteLine("negative number.");
            else Console.WriteLine("positive number.");
        }
    }
}
