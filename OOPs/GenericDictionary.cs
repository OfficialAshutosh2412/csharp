using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class GenericDictionary
    {
        Dictionary<string,object> dish=new();
        public GenericDictionary()
        {
            dish.Add("name", "Ashuotosh");
            dish.Add("salary",0);
            dish.Add("age", 24.5F);
        }
        public void show()
        {
            foreach(var item in dish)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
    }
}
