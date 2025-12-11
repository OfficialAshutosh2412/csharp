using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class MiddleDigitFinder
    {
        private int num = 0, num1 = 145, num2 = 154, num3 = 451, mid=0;
        internal void FindMids()
        {
            for(int i = 1; i <= 3; i++)
            {
                if (i == 1) num = num1;
                if(i == 2) num = num2;
                if(i == 3) num = num3;
                int originalNumber = num;
                for (int j = 1; j <= 2; j++)
                {
                    if(j==2)
                    {
                        mid = num % 10;
                    }
                    num = num / 10;
                }
                Console.WriteLine($"middle digit of {originalNumber} is : {mid}");
            }
        }
    }
}
