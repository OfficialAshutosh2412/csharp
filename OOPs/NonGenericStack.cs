using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class NonGenericStack
    {
        Stack st = new();
        public NonGenericStack() 
        {
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);
        }
        public void PopElement()
        {
            Console.WriteLine($"Popped element : {st.Pop()}");
        }
        public void show()
        {
            foreach (object item in st)
                Console.WriteLine($"element : {item}");
        }
    }

    internal class GenericStack
    {
        Stack<int> st = new();
        public GenericStack()
        {
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);
        }
        public void PopElement()
        {
            Console.WriteLine($"Popped element : {st.Pop()}");
        }
        public void show()
        {
            foreach (int item in st)
                Console.WriteLine($"element : {item}");
        }
    }
}
