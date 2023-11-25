using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexDemo
{
    internal class ComplexNumber
    {
        int real, imaginary;
        public ComplexNumber(int real,int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary; 
        }
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b) 
        {
            return new ComplexNumber(a.real+b.real,a.imaginary+b.imaginary);
        }
        public override string ToString() 
        {
            return $"sum is---> {real}+{imaginary}i";
        }
    }
}
