using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class ArrayOneBasic
    {
        //static array
        public void StaticArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i <= 9; i++)
                Console.Write(arr[i] + " ");
        }
        //dynamic array
        public void DynamicArray()
        {
            int n = 10;
            int[] arr = new int[n];
            for (int i = 0; i <= n - 1; i++)
            {
                Console.Write("Enter number : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for (int j = 0; j <= n - 1; j++) Console.Write(arr[j] + " ");
        }

        //max finding.
        public void MaxFinding()
        {
            int n = 10;
            int[] arr = new int[n];
            for (int i = 0; i <= n - 1; i++)
            {
                Console.Write("Enter number : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            int max = arr[0], secondMax = 0;
            for (int j = 0; j < n; j++)
            {
                if (arr[j] > max)
                {
                    secondMax = max;
                    max = arr[j];
                }
                Console.Write(arr[j] + " ");
            }
            Console.WriteLine($"\nMax 1= {max}");
            Console.WriteLine($"\nMax 2 = {secondMax}");
        }

        //unique elems
        public void UniqueElement()
        {
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter the number : ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Unique elements of array :");

            for (int i = 0; i < 10; i++)
            {
                int count = 0;
                for (int j = 0; j < 10; j++)
                {
                    if (num[i] == num[j]) count++;
                }
                if (count > 1) continue;
                else Console.Write(num[i] + " ");
            }
        }
        //repeated elems
        public void RepeatElement()
        {
            int[] num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter the number : ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Unique elements of array :");
            int temp = 0;
            for (int i = 0; i < 10; i++)
            {
                int count = 0;
                for (int j = 0; j < 10; j++)
                    if (num[i] == num[j]) count++;
                if (count > 1)
                {
                    if (num[i] != temp)
                    {
                        temp = num[i];
                        Console.Write(num[i] + " ");
                    }
                    else continue;
                }
                else continue;
            }

        }
    }
}
