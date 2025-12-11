using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class DateDifference
    {
        public int diff = 0;
        public int date1 = 12052016;
        public int date2 = 13062019;
        public void calculateDifference()
        {
            date1 = date1 % 10000;
            date2 = date2 % 10000;
            diff = date2 - date1;
            Console.WriteLine("difference is {0} years", diff);
        }
    }
}
