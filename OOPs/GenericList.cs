using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class GenericList
    {
        List<int> lis = new();
        public GenericList()
        {
            lis.Add(10);
            lis.Add(20);
            lis.Add(30);
        }
        public void show()
        {
            foreach (int item in lis)
                Console.WriteLine(item);
        }
    }

    internal class GenericListObject
    {
        List<object> lis = new();
        public GenericListObject()
        {
            lis.Add(10);
            lis.Add(20.5F);
            lis.Add("30 hai ye");
        }
        public void show()
        {
            foreach (object item in lis)
                Console.WriteLine(item);
        }
    }
}
