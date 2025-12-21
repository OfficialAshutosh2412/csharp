using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class MultiThreadExample
    {
        public void Task1()
        {
            Console.WriteLine();
            for(int i = 1; i <= 10; i++)
            {
                Console.Write(" Task 1 ");
                Thread.Sleep(500);
            }
        }
        public void Task2()
        {
            Console.WriteLine();
            for (int i = 11; i <= 20; i++)
            {
                Console.Write(" Task 2 ");
                Thread.Sleep(500);
            }
        }
        public void Task3()
        {
            Console.WriteLine();
            for (int i = 21; i <= 30; i++)
            {
                Console.Write(" Task 3 ");
                Thread.Sleep(500);
            }
        }
    }
}
