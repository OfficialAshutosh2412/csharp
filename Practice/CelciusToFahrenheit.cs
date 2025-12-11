using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class CelciusToFahrenheit
    {
        private double celcius, fah=0;
        internal void Calc()
        {
            Console.Write("enter degree in celcius : ");
            celcius = Convert.ToDouble(Console.ReadLine());
            fah = ((9 * celcius) / 5) + 32;
            Console.WriteLine($"{fah} degree Fahrenheit");
        }
    }
}
