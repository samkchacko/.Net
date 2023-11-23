using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    internal class Rectangle : shape
    {
        double length, height;
        public Rectangle(double l,double h)
        {
            this.height = h;
            this.length = l;
        }
        public override double Area()
        {
            return length*height;
        }
    }
}
