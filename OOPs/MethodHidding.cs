using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    internal class Bill
    {
        public double cal(double amount)
        {
            return amount;
        }
    }
    internal class GstBill : Bill
    {
        public new double cal(double amount)
        {
            return amount + amount* 0.18f;
        }
    }
}
