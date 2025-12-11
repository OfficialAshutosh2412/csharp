using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class ForLoopQuestions
    {
        //1 to 10 and 10 to 1 printing.
        public void OneToTenAndTenToOne()
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(i);
            Console.WriteLine("-------------reverse----------");
            for (int j = 10; j >= 1; j--)
                Console.WriteLine(j);
        }

        //table printing.
        public void TablePrint()
        {
            Console.Write("enter number to write table : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{num} X {i} = {num * i}");
        }

        //factorial of a number.
        public void Factorial()
        {
            Console.Write("enter number to find factorial : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int ognum = num;
            int fact = 1;
            Console.Write($"{num}! = ");
            for (int i = num; i >= 1; i--)
            {
                if (i == 1)
                {
                    Console.Write($"{i} = ");
                }
                else
                    Console.Write($"{i} X ");
                fact = fact * num;
                num--;
            }
            Console.WriteLine($"{fact}");
        }

        //employee
        public void EmployeeSalary()
        {
            Console.Write("Enter salary : ");
            int salary = Convert.ToInt32(Console.ReadLine());

            for (int empid = 1001; empid <= 1020; empid++)
            {
                if (empid == 1003 || empid == 1005 || empid == 1007) continue;
                if (salary >= 35000 && empid > 1015) break;
                Console.WriteLine($"Emp ID : {empid} And Salary : {salary}");
            }
        }

        //decimal to binary.
        public void DecimalToBinary()
        {
            Console.Write("enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            string result = "";
            for (int n = num; n >= 1; n = n / 2) result = (n % 2).ToString() + result;
            Console.WriteLine(result);
        }

        //binary to decimal
        public void BinaryToDecimal()
        {
            Console.Write("enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            int rightMost;
            for (int power = 0; num > 0; power++)
            {
                rightMost = num % 10;
                result = result + rightMost * (int)Math.Pow(2, power);
                num = num / 10;
            }
            Console.WriteLine(result);
        }

        //prime number printing.
        public void PrimeNumber()
        {

            for (int i = 2; i <= 20; i++)
            {
                int count = 0;
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count <= 1) Console.WriteLine($"{i} is a prime number");

            }
        }


        //reverse any number
        public void ReverseNumberUsingFor()
        {
            Console.Write("Enter number to reverse : ");
            int num = Convert.ToInt32(Console.ReadLine());
            string rev = "";
            int temp = num;
            for (int i = temp.ToString().Length; i >= 1; i--)
            {

                rev = rev + num % 10;
                num = num / 10;
            }
            Console.Write(rev);
        }

        //trinagle of star
        public void PatternTriangle()
        {
            //pattern 1
            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}

            //pattern 2
            //for (int i = 1; i <= 5; i++)
            //{
            //    char ch = 'A';
            //    for (int j = 5; j >= i; j--)
            //    {
            //        Console.Write(" " + ch + " ");
            //        ch++;
            //    }
            //    Console.WriteLine();
            //}

            //pattern 3
            //for (int i = 1; i <= 5; i++)
            //{
            //    char capch = 'A', lowch = 'a';
            //    for (int j = 5; j >= i; j--)
            //    {
            //        if (j % 2 != 0)
            //        {
            //            Console.Write(" " + capch + " ");
            //            capch++;
            //        }
            //        else
            //        {
            //            Console.Write(" " + lowch + " ");
            //            lowch++;
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //pattern 4
            //int space = 2;
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int s = 1; s <= space; s++)
            //    {
            //        Console.Write("   ");
            //    }
            //    space--;
            //    for (int j = 1; j <= 2 * i - 1; j++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}

            //pattern 5
            //int n = 5;
            //int space = 0;
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int s = 1; s <= space; s++)
            //    {
            //        Console.Write("   ");
            //    }
            //    space++;
            //    for (int j = 1; j <= n; j++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    n = n - 2;


            //    Console.WriteLine();
            //}

            //pattern 6
            //int space1 = 2;
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int s = 1; s <= space1; s++)
            //    {
            //        Console.Write("   ");
            //    }
            //    space1--;
            //    for (int j = 1; j <= 2 * i - 1; j++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}
            //int n = 3;
            //int space2 = 1;
            //for (int i = 1; i <= 2; i++)
            //{
            //    for (int s = 1; s <= space2; s++)
            //    {
            //        Console.Write("   ");
            //    }
            //    space2++;
            //    for (int j = 1; j <= n; j++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    n = n - 2;


            //    Console.WriteLine();
            //}

            //pattern 7
            //int n = 5;
            //int space3 = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int s = 1; s <= space3; s++)
            //    {
            //        Console.Write("   ");
            //    }
            //    space3++;
            //    for (int j = 1; j <= n; j++)
            //    {
            //        Console.Write(" " + j + " ");
            //    }
            //    n--;
            //    Console.WriteLine();
            //}

            //pattern 8
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 5; j >= i; j--)
            //    {
            //        if (j % 2 == 0)
            //        {
            //            Console.Write(" 0 ");
            //        }
            //        else Console.Write(" 1 ");


            //    }
            //    Console.WriteLine();
            //}

            //pattern 9
            //int space4 = 0;
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int s = 1; s <= space4; s++)
            //    {
            //        Console.Write("   ");
            //    }
            //    space4++;
            //    for (int j = 5; j >= i; j--)
            //    {
            //        if (i == 1 && j < 4) Console.Write(" 1 ");
            //        else if ((j + i) % 2 == 0) Console.Write(" 2 ");
            //        else Console.Write(" 1 ");
            //    }
            //    Console.WriteLine();
            //}

            //pattern 10
            //for (int i = 0; i <= 5; i++)
            //{
            //    for (int j = 0; j <= 5; j++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}
        }

        //table 1 to n
        public void TableToN()
        {
            Console.Write("Enter number to print table : ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("======================================");
                Console.WriteLine($"Table of {i} : ");
                Console.WriteLine("======================================");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
        }
    }
    internal class MainForLoop
    {
        public static void Main()
        {
            ForLoopQuestions fr = new();
            //fr.OneToTenAndTenToOne();
            //fr.TablePrint();
            //fr.Factorial();
            //fr.EmployeeSalary();
            //fr.DecimalToBinary();
            //fr.BinaryToDecimal();
            //fr.PrimeNumber();
            //fr.PatternSimpleMatrix();
            //fr.ReverseNumberUsingFor();
            //fr.PatternTriangle();
            //fr.TableToN();
        }
    }
}