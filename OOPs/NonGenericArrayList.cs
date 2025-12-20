using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class NonGenericArrayList
    {
        ArrayList al = new ArrayList();
        public NonGenericArrayList()
        {
            al.Add(1);
            al.Add(3);
            al.Add(5);
            al.Add(7);
        }
        public void show()
        {
            foreach (object o in al)
            {
                Console.WriteLine(o.ToString());
            }
        }
    }
}
