using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class NonStaticConstructor
    {
        internal NonStaticConstructor()
        {
            Console.WriteLine("Default constructor is running...");
        }
        internal NonStaticConstructor(int a, int b)
        {
            Console.WriteLine("Parameterized constructor is running...");
            Console.WriteLine("Addition : " + (a + b));
        }
    }
}
