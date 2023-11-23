using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    internal class Circle : shape
    {
        double radius;
        public Circle(double r)
        {
            this.radius = r;   
        }
        public override double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
