using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    internal class Trapezium : shape
    {
        double height, baseLength, upperLength;
        public Trapezium(double a,double b,double h)
        {
            
            this.upperLength = a;
            this.baseLength = b;
            this.height = h;
        }
        public override double Area()
        {
            return 0.5 * (baseLength + upperLength) * height;
        }
    }
}
