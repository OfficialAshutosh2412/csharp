using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class ClassAndObjectBasic
    {
        string name="";
        int roll=0;
        internal void setData(string x, int y)
        {
            this.name = x;
            this.roll = y;
        }
        internal void getData()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Roll number : " + roll);
        }
    }
    internal class Printer
    {
        public static void Main()
        {
            ClassAndObjectBasic cob = new();
            cob.setData("Ashutosh", 13256);
            cob.getData();
        }
    }
}
