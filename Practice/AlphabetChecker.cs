using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class AlphabetChecker
    {
        internal void check()
        {
            int numeric = 0;
            Console.Write("enter key to check : ");
            string key = Console.ReadLine()!;
            if (int.TryParse(key, out numeric)) Console.WriteLine("numeric");
            else Console.WriteLine("string");
        }
    }
}
