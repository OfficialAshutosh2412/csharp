using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal interface IEndUser
    {
        public void Signup();
        public void Signin();
    }
    internal interface IAdmininstrator
    {
        public void Dashboard();
        public void Analyze();
    }
    internal class SecureMultipleInheritanceByInterface:IEndUser,IAdmininstrator
    {
        public SecureMultipleInheritanceByInterface()
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
        //securing this admin methods, only accessible to admin.
        void IAdmininstrator.Dashboard()
        {
            Console.WriteLine("Admin dashboard...");
        }
        void IAdmininstrator.Analyze()
        {
            Console.WriteLine("Admin analyzes...");
        }
    }
}
