using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SquareAndCube
    {
        private int num, sqr=0, cube=0;
        internal void CalculateSquareAndCube() {
            Console.WriteLine("Please enter a number to find it's square and cube roots...");
            num = Convert.ToInt32(Console.ReadLine());
            sqr = num * num;
            cube = num * num * num;
            Console.WriteLine($"The Square root is : {sqr}");
            Console.WriteLine($"The Cube root is : {cube}");
        }
    }
}
