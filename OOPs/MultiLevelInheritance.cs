using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class MultiLevelInheritance
    {
        private int b;
        public static int c=900;
        private static int d=1000;
        public int  StaticPrivateVariable()
        {
            return d;
        }
        public int A { get; set; }
        public int B { get { return this.b; } set { this.b = value; } }
        public int Add(int x, int y)
        {
            return x + y;
        }
    }
    internal class Children:MultiLevelInheritance
    {
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
    internal class GrandChild:Children
    {
        public int Mul(int x, int y)
        {
            return x * y;
        }
    }
}
