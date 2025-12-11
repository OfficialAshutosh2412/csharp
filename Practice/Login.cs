using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Login
    {
        internal void SignIn()
        {
            Console.Write("Enter your firstname : ");
            string fname = Console.ReadLine()!;

            Console.Write("Enter your lastname : ");
            string lname = Console.ReadLine()!;

            Console.Write("Enter your username/firstname : ");
            string username = Console.ReadLine()!;

            Console.Write("Enter your password/lastname : ");
            string password = Console.ReadLine()!;

            if (username != fname || password != lname) Console.WriteLine("Invalid username and password.");
            else if (username != fname) Console.WriteLine("Invalid username.");
            else if (password != lname) Console.WriteLine("Invalid password.");
            else Console.WriteLine("login successfull !");

        }

    }
}
