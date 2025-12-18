using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class SingleInheritance
    {
        private int a, b, c;
        public int d = 100;
        public static double e = 2.4F;
        public int Add(int x, int y, int z)
        {
            return x + y + z;
        }
        public int A { get { return this.a; } set { this.a = value; } }
        public int B { get; set; }
        public int C { get; set; }

    }
    internal class Child : SingleInheritance
    {
        public int Sub(int x, int y) { return x - y; }
    }
}
