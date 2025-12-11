using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class ElectricityBill
    {
        private int unit_price=0;
        private double load=0, extra_load=0;
        internal void CalculateBill()
        {
            Console.Write("please enter unit price of your electricity connection : ");
            unit_price = Convert.ToInt32(Console.ReadLine());

            Console.Write("please enter energy units of your electricity connection : ");
            load = Convert.ToDouble(Console.ReadLine());

            Console.Write("please enter extra units consumed(enter zero --> 0 if no any extra units): ");
            extra_load = Convert.ToDouble(Console.ReadLine());

            double total_consumption = load * unit_price;
            double extra_load_price=extra_load * unit_price;
            double bill = total_consumption + extra_load_price;
            Console.WriteLine("\n====================== Consumption info ========================\n");
            Console.WriteLine($"Unit price : {unit_price} Rs/-\n");
            Console.WriteLine($"Energy unit : {load} kw/hr\n");
            Console.WriteLine($"Extra unit : {extra_load} kw/hr\n");

            Console.WriteLine("\n====================== Bill info ===============================\n");
            Console.WriteLine($"Unit charges : {total_consumption} Rs/-\n");
            Console.WriteLine($"Extra unit charges : {extra_load_price} Rs/-\n");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine($"Total bill : {bill} Rs/-");
            Console.WriteLine("----------------------------------------------------------------");
        }

    }
}
