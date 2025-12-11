using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SalaryIncrement
    {
        private double salary = 0, increment = 800;
        internal void calculate()
        {
            Console.WriteLine("enter the salary...");
            salary = Convert.ToDouble(Console.ReadLine());
            if (salary < 10000) increment = 500;
            salary = salary + increment;
            Console.WriteLine($"Salary = {salary}");
        }
    }
}
