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
            circle Circle = new circle();
            coordinate TopLeft = new coordinate();
            TopLeft.coords(12, 20);
            Circle.c = TopLeft;
            Circle.r = 5;
            rectangle Rectangle = new rectangle();
            Rectangle.c = TopLeft;
            Rectangle.height = 30;
            Rectangle.width = 50;
            Console.WriteLine("circle area: " + calculation.circle_area(Circle.r));
            Console.WriteLine("circle circumference: " + calculation.circle_circumference(Circle.r));
            Console.WriteLine("rectangle circumference: " + calculation.rectangle_circumference(Rectangle.height,Rectangle.width));
            Console.WriteLine("rectangle area: " + calculation.rectangle_area(Rectangle.height, Rectangle.width));


        }
    }
}
