using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_measurement
{
    class Program
    {
        static void Main(string[] args)
        {
            circle circle = new circle();
            coordinate topLeft = new coordinate();
            topLeft.coords(12, 20);
            circle.c = topLeft;
            circle.r = 5;
            rectangle rectangle = new rectangle();
            rectangle.c = topLeft;
            rectangle.height = 30;
            rectangle.height = 50;
            Console.WriteLine("circle area: " + calculation.circle_area(circle.r));
            Console.WriteLine("circle circumference: " + calculation.circle_circumference(circle.r));
            Console.WriteLine("rectangle circumference: " + calculation.rectangle_circumference(rectangle.height,rectangle.width));
            Console.WriteLine("rectangle area: " + calculation.rectangle_area(rectangle.height, rectangle.width));


        }
    }
}
