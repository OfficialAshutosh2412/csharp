using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class LeapTernary
    {
        private Int16 year = 2000;
        internal void FindLeap()
        {
            Console.Write("enter year to check leap or non leap : ");
            year = Convert.ToInt16(Console.ReadLine());
            string result = (year % 400 == 0) ? "leap year" : (year % 4 == 0 && year % 100 != 0) ? "leap year" : "non leap year";
            Console.WriteLine(result);

        }
    }
}
