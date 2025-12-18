using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    abstract public class Prototypes
    {
        abstract public void Sound();
    }
    internal class Cat:Prototypes
    {
        public override void Sound()
        {
            Console.WriteLine("Cat speaks : Mewo");
        }
    }
}
