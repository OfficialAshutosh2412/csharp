using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class YesNo
    {
        internal void check()
        {
            Console.Write("press y for yes, or n for no : ");
            char ch = Convert.ToChar(Console.Read());
            if (ch == 'y') Console.Write("yes");
            else Console.WriteLine("No");
        }
    }
}
