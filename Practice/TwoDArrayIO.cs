using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class TwoDArrayIO
    {
        //array input/output
        public void InputAndOutput()
        {
            int[,] arr = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Enter the element ({i},{j}) :  : ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    arr[i, j] = num;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write(arr[i, j] + " ");
                Console.WriteLine();
            }
        }

        //object array
        public void ObjectArray()
        {
            object[,] arr = new object[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("enter element : ");
                    string raw = Console.ReadLine()!;
                    if (int.TryParse(raw, out int intValue)) arr[i, j] = intValue;
                    else if (double.TryParse(raw, out double doubleValue)) arr[i, j] = doubleValue;
                    else arr[i, j] = raw;
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //jagged array
        public void JgggedArray()
        {
            int[][] arr = new int[3][];
            for (int i = 0; i < 3; i++)
            {
                arr[i] = new int[100];
                int count = 0;
                for (int j = 0; j < 100; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                    count++;
                    Console.Write("press c to continue or press b to break : ");
                    char ch = (char)Console.Read();
                    Console.ReadLine();
                    if (ch == 'b') break;
                }
                Array.Resize(ref arr[i], count);
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                    Console.Write(arr[i][j] + " ");
                Console.WriteLine();
            }
        }
    }
}
;