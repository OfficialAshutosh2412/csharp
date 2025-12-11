using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Grace
    {
        internal void Calculate()
        {
            const int passing_marks = 30;
            const int grace_limit = 27;
            int hgrace = 0, egrace = 0, mgrace = 0, scigrace = 0, socigrace = 0;

            Console.Write("enter hindi marsk : ");
            int hindi = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter english marsk : ");
            int english = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter maths marsk : ");
            int maths = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter science marsk : ");
            int science = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter social marsk : ");
            int social = Convert.ToInt32(Console.ReadLine());

            //hindi
            if (hindi >= grace_limit)
                hgrace = passing_marks - hindi;

            //eng
            if (english >= grace_limit)
                egrace = passing_marks - english;

            //maths
            if (maths >= grace_limit)
                mgrace = passing_marks - maths;

            //science
            if (science >= grace_limit)
                scigrace = passing_marks - science;

            //social
            if (social >= grace_limit)
                socigrace = passing_marks - social;

            Console.WriteLine("================================================================\n");
            Console.WriteLine($"Hindi marks : {hindi}");
            Console.WriteLine($"Grace marks : {hgrace}");
            Console.WriteLine($"Total Hindi marks : {hindi + hgrace}");
            Console.WriteLine("----------------------------------------------------------------\n");
            Console.WriteLine($"English marks : {english}");
            Console.WriteLine($"Grace marks : {egrace}");
            Console.WriteLine($"Total English marks : {english + egrace}");
            Console.WriteLine("----------------------------------------------------------------\n");
            Console.WriteLine($"Maths marks : {maths}");
            Console.WriteLine($"Grace marks : {mgrace}");
            Console.WriteLine($"Total Maths marks : {maths + mgrace}");
            Console.WriteLine("----------------------------------------------------------------\n");
            Console.WriteLine($"Science marks : {science}");
            Console.WriteLine($"Grace marks : {scigrace}");
            Console.WriteLine($"Total Science marks : {science + scigrace}");
            Console.WriteLine("----------------------------------------------------------------\n");
            Console.WriteLine($"Social Study marks : {social}");
            Console.WriteLine($"Grace marks : {socigrace}");
            Console.WriteLine($"Total Social Study marks : {social + socigrace}");
            Console.WriteLine("\n================================================================");

        }
    }
}
