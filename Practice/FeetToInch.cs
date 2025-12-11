using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class FeetToInch
    {
        internal double feet = 22, inch=0;
        internal void CalFeetToInch() {
            inch = feet * 12;
            Console.WriteLine("{0} feet = {1} inch",feet, inch);
        }
    }
}
