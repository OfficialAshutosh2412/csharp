using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SalaryTaxation
    {
        double salary = 0, taxable_amount = 0, total_amt = 0;
        internal void ComputeSalary()
        {
            Console.Write("please enter your salary only in digits(no commas) : ");
            salary = Convert.ToDouble(Console.ReadLine());

            taxable_amount = (salary <= 400000) ? calculateTax(salary, 0) :
            (salary > 400000 && salary <= 800000) ? calculateTax(salary, 5) :
            (salary > 800000 && salary <= 1200000) ? calculateTax(salary, 10) :
            (salary > 1200000 && salary <= 1600000) ? calculateTax(salary, 15) :
            (salary > 1600000 && salary <= 2000000) ? calculateTax(salary, 20) :
            (salary > 2000000 && salary <= 2400000) ? calculateTax(salary, 25) :
            calculateTax(salary, 30);

            //total amount
            total_amt = salary - taxable_amount;
            Console.WriteLine($"Taxable Amount : {taxable_amount}");
            Console.WriteLine($"Total Amount : {total_amt}");
        }
        internal double calculateTax(double salary, int tax)
        {
            //taxable amt
            taxable_amount = salary * (tax / 100.0);
            return taxable_amount;
        }
    }
}
