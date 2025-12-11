using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SalaryIF
    {
        internal void CalcSalary()
        {
            Console.Write("enter salary of employee : ");
            double salary = Convert.ToDouble(Console.ReadLine());
            if (salary < 10000)
            {
                salary += 500;
                Console.WriteLine($"revised salary is : rs {salary}/-");
            }
            else Console.WriteLine($"no revision, salary is : rs {salary}/-");
        }
    }
}
