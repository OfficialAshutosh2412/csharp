using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class NonGenericSortedList
    {
        SortedList s = new SortedList();
        public NonGenericSortedList()
        {
            s.Add("zebra", "animal");
            s.Add("Giraffe", "animal");
            s.Add("sparrow", "bird");
            s.Add("Bagula", "bird");
        }
        public void show()
        {
            Console.WriteLine("Non Generic SortedList...");
            foreach(DictionaryEntry d in s)
            {
                Console.WriteLine($"{d.Key} : {d.Value}");
            }
            Console.WriteLine("\ndata is sorted by default...\n");
        }
    }
    internal class GenericSortedList
    {
        SortedList<string,object> gsl =new();
        public GenericSortedList()
        {
            gsl.Add("zebra", "animal");
            gsl.Add("Giraffe", "animal");
            gsl.Add("sparrow", "bird");
            gsl.Add("Bagula", "bird");
        }
        public void show()
        {
            Console.WriteLine("Generic SortedList...");
            foreach (KeyValuePair<string,object> d in gsl)
            {
                Console.WriteLine($"{d.Key} : {d.Value}");
            }
            Console.WriteLine("\ndata is sorted by default...\n");
        }
    }
}
