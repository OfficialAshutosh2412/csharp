using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Person
    {
        internal void Legs(string l1, string l2)
        {
            Console.WriteLine($"Person have {l1} and {l2} both legs");
        }
        internal void Legs()
        {
            Console.WriteLine("Reptiles have no legs.");
        }
    }
}
