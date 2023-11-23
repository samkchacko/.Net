using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeDemo
{
    internal class Triangle : shape
    {
        double baseLenght,height;
        public Triangle(double b,double h)
        {
            this.baseLenght = b;
            this.height = h;
        }
        public override double Area()
        {
            return baseLenght * height * 0.5;
        }
    }
}
