using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Circle
    {
        internal int p1;
        internal void GetParam1(int p1)
        {
            this.p1 = p1;
        }
        internal void AreaOfCircle()
        {
            Console.WriteLine($"Area of circle : {Math.PI * p1 * p1}");
        }
    }
    internal class Triangle:Circle
    {
        internal int p2;
        internal void GetParam2(int p2)
        {
            this.p2 = p2;
        }
        internal void AreaOfTraingle()
        {
            Console.WriteLine($"Area of triangle : {(p1*p2)/2}");
        }
    }
    internal class Rectangle:Triangle
    {
        internal void AreaOfRectangle()
        {
            Console.WriteLine($"Area of rectangle : {p1*p2}");
        }
    }

}
