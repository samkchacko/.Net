using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    internal class Complex
    {
        public int real, imaginary;

        //public int Real { get {return real;}}
        //public int Imaginary { get { return imaginary;} }
        public Complex(int r,int im)
        {
            this.real = r;
            this.imaginary = im;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            Complex complex = new Complex(a.real+b.real,a.imaginary+b.imaginary);
            return complex;
        }
        public override string ToString()
        {
            return $"{real}+{imaginary}i";
        }
    }
}
