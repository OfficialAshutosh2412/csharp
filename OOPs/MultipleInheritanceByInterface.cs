using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal interface IUser
    {
        public void Signup();
        public void Signin();
    }
    internal interface IAdmin
    {
        public void Dashboard();
        public void Analyze();
    }
    internal class MultipleInheritanceByInterface:IUser,IAdmin
    {
        public MultipleInheritanceByInterface()
        {
            Console.WriteLine("Greetings !");
        }
        public void Signup()
        {
            Console.WriteLine("User Signup...");
        }
        public void Signin()
        {
            Console.WriteLine("User Signin...");
        }
        public void Dashboard()
        {
            Console.WriteLine("Admin dashboard...");
        }
        public void Analyze()
        {
            Console.WriteLine("Admin analyzes...");
        }
    }
}
