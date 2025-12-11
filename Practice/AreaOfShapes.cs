using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class AreaOfShapes
    {
        const double base_of_triangle = 14.5, height_of_rectangle = 23.7, pi = 3.14;
        private double height_of_triangle;
        private double width_of_rectangle;
        private double radius_of_circle;
        internal void CalculateArea()
        {
            Console.Write("enter height of triangle : ");
            height_of_triangle=Convert.ToDouble(Console.ReadLine());

            double area_of_triangle=(base_of_triangle*height_of_triangle)/2;
            Console.WriteLine("==================================================");
            Console.WriteLine($"Area of triangle is : {area_of_triangle}");
            Console.WriteLine("==================================================\n");

            Console.Write("enter width of rectangle : ");
            width_of_rectangle = Convert.ToDouble(Console.ReadLine());
            double area_of_rectangle = width_of_rectangle * height_of_rectangle;
            Console.WriteLine("==================================================");
            Console.WriteLine($"Area of rectangle is : {area_of_rectangle}");
            Console.WriteLine("==================================================\n");

            Console.Write("enter radius of circle : ");
            radius_of_circle = Convert.ToDouble(Console.ReadLine());
            double area_of_circle = pi*(radius_of_circle*radius_of_circle);
            Console.WriteLine("==================================================");
            Console.WriteLine($"Area of circle is : {area_of_circle}");
            Console.WriteLine("==================================================\n");
        }

    }
}
