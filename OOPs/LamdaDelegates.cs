using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Processor
    {
        public void Execute(int a, int b, Action<int,int> operation)
        {
            operation(a, b);
        }
    }
    internal class OperationFunctions
    {
        public void Add(int a, int b) => Console.WriteLine(a + b);
        public void Sub(int a, int b) => Console.WriteLine(a - b);
    }
}
