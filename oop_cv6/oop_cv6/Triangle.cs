using System;
using System.Collections.Generic;
using System.Text;

namespace oop_cv6
{
    internal class Triangle : Object2D
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double S { get; set; }
        
        
        public Triangle(double a, double b, double c) 
        {
            A = a;
            B = b;
            C = c;
            S = a + b + c/2;
        }
        
        public override double CalcArea()
        {
             
            return Math.Sqrt(S*(S-A)*(S-B)*(S-C));      
        }

        public override string ToString()
        {
            return String.Format("Triangle ( a = {0}, b= {1}, c= {2} )",A, B, C);
        }
        public override string Draw()
        {
            return ToString();
        }
    }
}
