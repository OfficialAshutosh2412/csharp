using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class EmployeeCalc
    {
        double ta = 10, da = 15, hra = 12, com = 5, pf = 8;
        double ta_of_salary = 0, da_of_salary = 0, hra_of_salary = 0, com_of_salary = 0, pf_of_salary = 0;
        double days = 0, basic_salary = 0, leaves = 0;
        internal void StartCalculation()
        {
            Console.WriteLine("====================================================");
            Console.WriteLine("             Employee Salary Management             ");
            Console.WriteLine("====================================================\n");

            //input
            Console.WriteLine("please enter the basic salary of employee...");
            basic_salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("please enter the no. of leaves taken by employee...");
            leaves = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("please enter the no. of days on a month...");
            days = Convert.ToDouble(Console.ReadLine());

            // Display input summary
            Console.WriteLine("-------------------- Basic info --------------------");
            Console.WriteLine("Basic Salary : {0} Rs/-\nLeaves : {1} days\nDays : {2} days\n", basic_salary, leaves, days);

            // Calculate Allowances & Deductions
            CalculateAllowance(basic_salary, leaves);

            //calculate salary deduction on leave, gross salary and net salary.
            CalculateActualSalary(basic_salary,days, leaves, ta_of_salary, da_of_salary,hra_of_salary, com_of_salary, pf_of_salary);
        }

        //Function to Calculate Allowances & Deductions
        internal void CalculateAllowance(double basic_salary, double leaves)
        {
            ta_of_salary = (ta / 100)*basic_salary;
            da_of_salary = (da / 100) * basic_salary;
            hra_of_salary = (hra / 100) * basic_salary;
            com_of_salary = (com / 100) * basic_salary;
            pf_of_salary = (pf / 100) * basic_salary;
            Console.WriteLine("-------------- Allowances & Deductions -------------");
            Console.WriteLine("Travel Allowance({0}%) : {1} Rs/-",ta,ta_of_salary);
            Console.WriteLine("Dearness Allowance({0}%) : {1} Rs/-", da,da_of_salary);
            Console.WriteLine("House Rent Allowance({0}%) : {1} Rs/-",hra,hra_of_salary);
            Console.WriteLine("Commision({0}%) : {1} Rs/-",com,com_of_salary);
            Console.WriteLine("Provident Fund({0}%) : {1} Rs/-\n",pf,pf_of_salary);
        }

        //Function to Calculate salary deduction on leave, gross salary and net salary
        internal void CalculateActualSalary(double basic_salary,  double days, double leaves,double ta_of_salary, double da_of_salary, double hra_of_salary, double com_of_salary,double  pf_of_salary)
        {
            //per day salary
            double per_day_salary = basic_salary / days;

            //salary deduction based on leaves.
            double leave_amount_deduction = per_day_salary * leaves;

            //gross salary
            double gross_salary = basic_salary + ta_of_salary + da_of_salary + hra_of_salary + com_of_salary;

            //net salary
            double net_salary = gross_salary - pf_of_salary - leave_amount_deduction;

            //console outputs
            Console.WriteLine("-------------------- Salary info -------------------");
            Console.WriteLine($"Your gross salary : {gross_salary:F2} Rs/-");
            Console.WriteLine($"Your per day salary : {per_day_salary:F2} Rs/-");
            Console.WriteLine($"Your salary deducted based on leave : {leave_amount_deduction:F2} Rs/-");
            Console.WriteLine($"Your credited salary : {net_salary:F2} Rs/-\n");
            Console.WriteLine("====================================================\n");
        }
    }
    internal class EmployeeManagement
    {
        public static void Main(string[] args)
        {
            EmployeeCalc emp = new();
            emp.StartCalculation();
        }
    }
}
