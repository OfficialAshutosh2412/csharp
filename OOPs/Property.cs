using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Property
    {
        private int marks;
        public int _Total { get; set; }
        public int _Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }

    }
}
