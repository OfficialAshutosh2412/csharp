using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public delegate void Calculate(int a, int b);
    internal class DelegateClass
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Addition of {a} + {b} : {a + b}");
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine($"Subtraction of {a} - {b} : {a - b}");
        }
        public void Mul(int a, int b)
        {
            Console.WriteLine($"Multiplication of {a} * {b} : {a * b}");
        }
        public void Div(int a, int b)
        {
            Console.WriteLine($"Division of {a} / {b} : {a / b}");
        }
    }
}
