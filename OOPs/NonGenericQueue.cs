using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class NonGenericQueue
    {
        Queue q = new();
        public NonGenericQueue()
        {
            q.Enqueue("Ashutosh Prasad");
            q.Enqueue(24);
            q.Enqueue(37000.30);
        }
        public void RemoveElement()
        {
            Console.WriteLine($"Removed Element : {q.Dequeue()}");
        }
        public void show()
        {
            foreach(object item in q)
            {
                Console.WriteLine($"Element : {item}");
            }
        }
    }

    internal class GenericQueue
    {
        Queue<int> q = new();
        public GenericQueue()
        {
            q.Enqueue(24);
            q.Enqueue(37000);
        }
        public void RemoveElement()
        {
            Console.WriteLine($"Removed Element : {q.Dequeue()}");
        }
        public void show()
        {
            foreach (object item in q)
            {
                Console.WriteLine($"Element : {item}");
            }
        }
    }
}
