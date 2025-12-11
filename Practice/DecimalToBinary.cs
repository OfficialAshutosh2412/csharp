using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class DecimalToBinary
    {
        internal int num = 10,rem;
        string binary = "";
        internal void CalDecimalToBinary() 
        {
            rem = num % 2;//0
            num = num / 2;//5
            binary = rem.ToString()+binary;//""+0=0

            rem = num % 2;//1
            num = num / 2;//2
            binary = rem.ToString() + binary;//1+0=10

            rem = num % 2;//0
            num=num / 2;//1
            binary = rem.ToString() + binary;//0+10=010

            rem =num % 2;//1
            num = num / 2;//0
            binary = rem.ToString() + binary;//1+010=1010

            Console.WriteLine("Binary of 10 is {0}", binary);
        }
    }
}
