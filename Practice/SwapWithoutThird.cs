using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SwapWithoutThird
    {
        private int a, b;
        internal void swap()
        {
            Console.Write("enter value of a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of b : ");
            b = Convert.ToInt32(Console.ReadLine());
            a = a + b;//30
            b = a-b;//b=10
            a = a - b;//30-10=20
            Console.WriteLine($"a={a}, b={b}");
        }
    }
}
