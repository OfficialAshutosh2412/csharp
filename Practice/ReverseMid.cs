using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class ReverseMid
    {
        private int first, rem, last, num=12345;
        private string rev="";
        internal void Reverse()
        {
            //1
            last = num % 10;//last=5
            num = num / 10;//1234
            //2
            rev = rev+(num % 10).ToString();//4
            num=num / 10;//123
            //3
            rev = rev + (num % 10).ToString();//3
            num = num / 10;//12
            //4
            rev = rev + (num % 10).ToString();//2
            num = num / 10;//1
            //5
            first = num % 10;//first=current value of num
            Console.WriteLine(first.ToString() + rev + last.ToString());
        }

    }
}
