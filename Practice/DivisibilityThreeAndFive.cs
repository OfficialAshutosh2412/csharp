using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class DivisibilityThreeAndFive
    {
        internal void Check() {
            Console.Write("enter any number : ");
            Int16 num = Convert.ToInt16(Console.ReadLine());
            string result = (num % 3 == 0 && num % 5 == 0) ? "divisible by 3 and 5 both" : "not divisible by either 3 and 5 both";
            Console.WriteLine(result);
        }
    }
}
