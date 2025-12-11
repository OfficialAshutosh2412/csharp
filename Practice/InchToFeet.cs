using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class InchToFeet
    {
        internal double inch = 6;
        internal double feet;
        internal void CalInchToFeet()
        {
            feet = inch / 12;
            Console.WriteLine("{0} inch = {1} feet", inch, feet);
        }       
    }
}
