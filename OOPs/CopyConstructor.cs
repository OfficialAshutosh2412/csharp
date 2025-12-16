using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class CopyConstructor
    {
        int a, b;
        public CopyConstructor()
        {
            a = 10; b = 20;
        }
        public CopyConstructor(CopyConstructor ctr)
        {
            this.a = ctr.a;
            this.b = ctr.b;
            Console.WriteLine("Copy constructor is running...");
            Console.WriteLine("Addition is : "+(a+b));
        }
    }
}
