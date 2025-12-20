using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class ExceptionHandling
    {
        public ExceptionHandling()
        {
            Console.WriteLine("Handling started...");
        }
    }
    internal class MyCode
    {
        public int Div(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine("System Message : " + ex.Message.ToString());
                Console.WriteLine("User-defined Message : cannot divide by zero");
                return 0;
            }
        }
    }
    internal class FinallyKeyword
    {
        public int Div(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine("System Message : " + ex.Message.ToString());
                Console.WriteLine("User-defined Message : cannot divide by zero");
                return 0;
            }
            finally
            {
                Console.WriteLine("Final Block : program returns 0");
            }
        }
    }

    internal class NegativeNumber
    {
        public int GetNumber(int a)
        {
            try
            {
                if (a < 0)
                {
                    throw new Exception();
                }
                return a;
            }
            catch (Exception ex)
            {
                Console.WriteLine("System Message : " + ex.Message.ToString());
                Console.WriteLine("User-defined Message : cannot give zero");
                return 0;
            }
            finally
            {
                Console.WriteLine("Final Block : program returns 0");
            }
        }
    }
    //creating user defined negative number exception...
    internal class NegativeNumberException : Exception
    {
        public NegativeNumberException() : base("Cannot accept negative number...")
        {

        }
    }
    //age restriction exception 
    internal class BelowEighteenException : Exception
    {
        public BelowEighteenException() : base("Age is more than 18.")
        {

        }
    }
    //using this exception
    internal class NumberAcceptor
    {
        public int GetNumber(int a)
        {
            try
            {
                if (a < 0)
                {
                    throw new NegativeNumberException();
                }
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User-defined Exception Message : " + ex.Message.ToString());
                Console.WriteLine("User-defined Message : cannot give zero");
                return 0;
            }
            finally
            {
                Console.WriteLine("Final Block : program returns 0");
            }
        }
    }
    internal class AgeAcceptor
    {
        public int GetAge(int age)
        {
            try
            {
                if (age > 18)
                {
                    throw new BelowEighteenException();
                }
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("User-defined Exception Message : " + ex.Message.ToString());
                Console.WriteLine("User-defined Message : Not eligible.");
                return 0;
            }
        }
    }
}
