using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Smartphone
    {
        virtual internal void Specs(string name, string os)
        {
            name = "Realme";
            os = "Android";
            Console.WriteLine($"Name : {name} and OS : {os}");
        }
    }
    internal class Laptop:Smartphone
    {
        override internal void Specs(string name, string os)
        {
            base.Specs(name,os);
            Console.WriteLine($"Name : {name} and OS : {os}");
        }
    }
}
