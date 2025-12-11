using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class SwitchQuestions
    {
        //even odd finder
        public void OddEven()
        {
            Console.WriteLine("Odd/Even finder.");
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num % 2)
            {
                case 0:
                    Console.WriteLine("Even number");
                    break;
                default:
                    Console.WriteLine("Odd number");
                    break;
            }
        }

        //greater number finder.
        public void MaxFinder()
        {
            Console.WriteLine("Greater finder.");
            Console.WriteLine("enter number1");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter number2");
            double num2 = Convert.ToDouble(Console.ReadLine());
            switch (num1 > num2)
            {
                case true:
                    Console.WriteLine("Number1 is greater : " + num1);
                    break;
                default:
                    Console.WriteLine("Number2 is greater : " + num2);
                    break;
            }
        }

        //yes/no/cancel detector.
        public void YesNoCancel()
        {
            Console.WriteLine("Yes / No / Cancel detector.");
            Console.Write("press y for yes / press n for no / press c for cancel : ");
            char option = Convert.ToChar(Console.Read());
            switch (option)
            {
                case 'y':
                case 'Y':
                    Console.WriteLine("YES");
                    break;
                case 'n':
                case 'N':
                    Console.WriteLine("NO");
                    break;
                case 'c':
                case 'C':
                    Console.WriteLine("CANCEL");
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
        }

        //leap year
        public void LeapNonLeap()
        {
            Console.WriteLine("enter year to check leap/non-leap year...");
            int year = Convert.ToInt32(Console.ReadLine());
            switch (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                case true:

                    Console.WriteLine("leap year");
                    break;
                default:
                    Console.WriteLine("non-leap year");
                    break;
            }
        }

        //character type detector
        public void CharacterDetector()
        {
            Console.Write("enter only one character : ");
            char character = Convert.ToChar(Console.Read());
            int result = 0;
            if ((character >= 65 && character <= 90) || (character >= 97 && character <= 122)) result = 1;
            else if (character >= 48 && character <= 57) result = 2;
            else result = 3;
            switch (result)
            {
                case 1:
                    Console.WriteLine($"{character} is a character.");
                    break;
                case 2:
                    Console.WriteLine($"{character} is a digit.");
                    break;
                default:
                    Console.WriteLine($"{character} is a special character.");
                    break;
            }
        }
    }
}
