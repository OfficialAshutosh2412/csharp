using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal interface ISpeak
    {
        public void Greet()
        {
            Console.WriteLine("Hello Programmer");
        }
        public void Speak();
    }
    internal class Dog : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Dog Barks...");
        }
    }
}
