using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class CompundInterest
    {
        private double p, r, n, t;
        private double A, ci;
        internal void Calculate()
        {
            Console.Write("enter the amount you diposited in bank : ");
            p = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter rate of interest offered by bank : ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter the number of time interest compunded per year : ");
            n = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter time in years : ");
            t = Convert.ToDouble(Console.ReadLine());

            A = p * Math.Pow((1 + ((r/100) / n)), n * t);
            ci = A - p;
            Console.WriteLine("\n===============================================================\n");
            Console.WriteLine($"After {t} years you will get total amount is : {A:F2} Rs/-\n");
            Console.WriteLine($"After {t} years you will get interest amount = {ci:F2} Rs/-\n");
            Console.WriteLine("===============================================================");
        }
    }
    internal class Runner
    {
        public static void Main()
        {
            CompundInterest ci = new();
            ci.Calculate();
        }
    }
}
