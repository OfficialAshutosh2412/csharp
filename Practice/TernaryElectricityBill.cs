using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Practice
{
    internal class TernaryElectricityBill
    {
        double unit = 0, consumption = 0;
        string result = "";
        internal void Call()
        {
            Console.Write("enter unit price : ");
            unit = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter consumption : ");
            consumption = Convert.ToDouble(Console.ReadLine());

            double bill = consumption * unit;

            result = (bill < 400) ? "payable amount : rs 100/-" : calc_price(bill);
            Console.WriteLine("===========================================");
            Console.WriteLine($"original bill : rs {bill}/-");
            Console.WriteLine($"after discount, {result}");
            Console.WriteLine("===========================================");

        }
        internal string calc_price(double bill)
        {
            double amt;
            amt = (bill*5)/10;
            return $"payable amount : rs {amt}/-";
        }
    }
}
