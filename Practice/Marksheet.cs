using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Marksheet
    {
        public void ProcessData()
        {
            //variables
            int graceRace = 0, count = 0;
            double percent = 0, hindi = 0, english = 0, math = 0, science = 0, art = 0;
            string failed_subjects = "", supplement_subjects = "", distinct_subjects = "", division = "", graceSubject = ""; 

            //getting input data
            Console.Write("Hindi Marks = ");
            hindi = Convert.ToDouble(Console.ReadLine());
            Console.Write("English Marks = ");
            english = Convert.ToDouble(Console.ReadLine());
            Console.Write("Maths Marks = ");
            math = Convert.ToDouble(Console.ReadLine());
            Console.Write("Science Marks = ");
            science = Convert.ToDouble(Console.ReadLine());
            Console.Write("Arts Marks = ");
            art = Convert.ToDouble(Console.ReadLine());

            //checking if number does not exceed 100 and not les than 0
            if (hindi < 0 || hindi > 100 || english < 0 || english > 100 || math < 0 || math > 100 || science < 0 || science > 100 || art < 0 || art > 100)
            {
                Console.WriteLine("Error : Invalid marks entry.");
                return;
            }

            //adding 5 grace marks.
            if (hindi >= 28 && hindi < 33) graceRace++;
            if (english >= 28 && english < 33) graceRace++;
            if (math >= 28 && math < 33) graceRace++;
            if (science >= 28 && science < 33) graceRace++;
            if (art >= 28 && art < 33) graceRace++;

            //giving grace
            if (graceRace == 1)
            {
                if (hindi < 33) { hindi += 5; graceSubject = "Hindi"; }
                else if (english < 33) { english += 5; graceSubject = "English"; }
                else if (math < 33) { math += 5; graceSubject = "Maths"; }
                else if (science < 33) { science += 5; graceSubject = "Science"; }
                else if (art < 33) { art += 5; graceSubject = "Arts"; }
            }

            //supplement subject finding, if less than 33 or calculating percentage and distinction.
            if (hindi >= 33)
            { if (hindi >= 80) distinct_subjects = "Hindi"; }
            else
            {
                count += 1;
                supplement_subjects = "Hindi";
            }

            if (english >= 33)
            { if (english >= 80) distinct_subjects = distinct_subjects + " English"; }
            else
            {
                count += 1;
                supplement_subjects = supplement_subjects + " English";
            }

            if (math >= 33)
            { if (math >= 80) distinct_subjects = distinct_subjects + " Maths"; }
            else
            {
                count += 1;
                supplement_subjects = supplement_subjects + " Maths";
            }

            if (science >= 33)
            { if (science >= 80) distinct_subjects = distinct_subjects + " Science"; }
            else
            {
                count += 1;
                supplement_subjects = supplement_subjects + " Science";
            }

            if (art >= 33)
            { if (art >= 80) distinct_subjects = distinct_subjects + " Arts"; }
            else
            {
                count += 1;
                supplement_subjects = supplement_subjects + " Art";
            }

            //Marksheet Report
            Console.WriteLine("===========================================================");
            Console.WriteLine("                         Marksheet                         ");
            Console.WriteLine("===========================================================\n");
            Console.WriteLine($"Hindi\t:\t{(graceSubject == "Hindi" ? hindi + " (pass by grace)" : hindi.ToString())}");
            Console.WriteLine($"English\t:\t{(graceSubject == "English" ? english + " (pass by grace)" : english.ToString())}");
            Console.WriteLine($"Maths\t:\t{(graceSubject == "Maths" ? math + " (pass by grace)" : math.ToString())}");
            Console.WriteLine($"Science\t:\t{(graceSubject == "Science" ? science + " (pass by grace)" : science.ToString())}");
            Console.WriteLine($"Arts\t:\t{(graceSubject == "Arts" ? art + " (pass by grace)" : art.ToString())}");
            Console.WriteLine("----------------------------------------------------------\n");

            //setting supplementary and failed subjects.
            if (count > 1)
            {
                failed_subjects = supplement_subjects;
                Console.WriteLine("Failed subjects\t:\t" + failed_subjects);
            }
            else if (count == 1) Console.WriteLine("Supplement subjects\t:\t" + supplement_subjects);
            else
            {
                Console.WriteLine("Supplement subjects\t:\tNo supplement subject");
            }

            //distinction printing.
            Console.WriteLine("----------------------------------------------------------\n");
            Console.WriteLine("Distinction\t:\t" + (string.IsNullOrEmpty(distinct_subjects) ? "No Distinction Granted" : distinct_subjects));
            Console.WriteLine("----------------------------------------------------------\n");
            //compute percentage
            if (hindi >= 33 && english >= 33 && math >= 33 && science >= 33 && art >= 33)
            {
                percent = ((hindi + english + math + science + art) / 500) * 100;
                if (percent >= 60) division = "First Division";
                else if (percent >= 45 && percent < 59) division = "Second Division";
                else if (percent >= 33 && percent < 44) division = "Third Division";
                else division = "Failed";
                Console.WriteLine("Percentage\t:\t" + percent.ToString("0.00") + "%");
            }
            else Console.WriteLine("Percentage\t:\t" + "No percentage is granted.");
            Console.WriteLine("----------------------------------------------------------\n");
            if (count == 0) Console.WriteLine("Final Result\t:\tPassed by " + division);
            else if (count == 1) Console.WriteLine("Final Result\t:\tSupplement");
            else Console.WriteLine("Final Result\t:\tFailed");
            Console.WriteLine("----------------------------------------------------------\n");
        }
    }
    public class Execute
    {
        public static void Main()
        {
            Marksheet m = new();
            m.ProcessData();
        }
    }
}
