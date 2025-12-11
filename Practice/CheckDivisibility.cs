using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class CheckDivisibility
    {
        internal void CheckNow()
        {
            Console.Write("enter any number : ");
            Int16 num = Convert.ToInt16(Console.ReadLine());
            string result = (num % 3 == 0 && num % 5 == 0) ? "divisible by 3 and 5 both" : (num % 3 == 0)? "divisible by 3": (num % 5 == 0) ? "divisible by 5": "not divisible by 3 and 5 both";
            Console.WriteLine(result);
        }
    }
}
