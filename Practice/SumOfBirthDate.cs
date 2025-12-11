using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{   
    internal class SumOfBirthDate
    {
        internal int bdate = 12052016, sum = 0;
        internal void SumOfDate()
        {
            sum =sum+ bdate % 10;//6
            bdate = bdate / 10;//1205201

            sum =sum+ bdate % 10;//1
            bdate = bdate / 10;//102520

            sum = sum + bdate % 10;//0
            bdate = bdate / 10;//10252

            sum = sum + bdate % 10;//2
            bdate = bdate / 10;//1025

            sum = sum + bdate % 10;//5
            bdate = bdate / 10;//102

            sum = sum + bdate % 10;//2
            bdate = bdate / 10;//10

            sum = sum + bdate % 10;//0
            bdate = bdate / 10;//1

            sum = sum + bdate % 10;//1

            Console.WriteLine("Sum of birthdate is {0}",sum);
        }
    }
}
