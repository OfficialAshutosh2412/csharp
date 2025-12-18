using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Encapsulation
    {
        private int a;
        public void One()
        {
            a = 100;
            Console.WriteLine(a);
        }
        public int A
        {
            get { return this.a; }
            set { this.a = value; }
        }
        public int B { get; set; }
    }
}
