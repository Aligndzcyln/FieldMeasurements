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
    class calculation
    {
        
    }
}
