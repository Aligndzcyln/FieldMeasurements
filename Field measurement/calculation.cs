using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field_measurement
{
    public struct coordinate
    {
        public int X;
        public int Y;
        public void coords(int pX,int pY)
        {
            X = pX;
            Y = pY;
        }//Constructor method
    }
    public struct circle
    {
        public double r;
        public coordinate c;
    }//top left corner
    public struct rectangle
    {
        public double height, width;
        public coordinate c;
    }
    class calculation
    {
        public static coordinate centre_of_Circumference(coordinate topLeft,double radius)
        {
            coordinate centre;
            centre.X = (int)(topLeft.X + radius);
            centre.Y = (int)(topLeft.Y + radius);
            return centre;
        }
        public static coordinate centre_of_rectangle(coordinate topLeft,double height,double width)
        {
            coordinate centre;
            centre.X = (int)(topLeft.X + (width / 2));
            centre.Y = (int)(topLeft.Y + (height) / 2);
            return centre;
        }
        public static double circle_area(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        public static double rectangle_area(double width,double height)
        {
            return width * height;
        }
        public static double rectangle_circumference(double width,double height)
        {
            return (width * height) * 2;
        }
        public static double circle_circumference(double r)
        {
            return Math.PI * r * 2;
        }
    }
}
