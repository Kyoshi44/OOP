using System;
using System.Collections.Generic;
using System.Text;

namespace oop_cv6
{
    internal class Rectangle : Object2D
    {
        

        public Rectangle(double a , double b) 
        {
            A = a;
            B = b;
        }
        public double A { get; private set; }
        public double B { get; private set; }
        public override double CalcArea()
        {
            return  A * B;
        }

        public override string ToString()
        {
            return String.Format("Obdelnik ( a = {0}, b= {1} )",A, B);
        }
        public override string Draw()
        {
            return ToString(); 
        }

    }
}
