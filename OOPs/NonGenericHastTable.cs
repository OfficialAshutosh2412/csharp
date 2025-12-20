using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class NonGenericHastTable
    {
        Hashtable hs=new Hashtable();
        public NonGenericHastTable()
        {
            hs.Add("name", "Ashutosh Prasad");
            hs.Add("role", "Dev");
            hs.Add("salary", "nothing");
            hs.Add("anchor", "never");
        }
        public void show()
        {
            foreach(DictionaryEntry d in hs)
            {
                Console.WriteLine($"{d.Key} : {d.Value}");
            }
            Console.Write("Data is printing in ascending order according to key...\n");
        }
    }
}
