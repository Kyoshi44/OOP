using System;
using System.Collections.Generic;
using System.Text;

namespace oop_cv6
{
    internal class Circle : Object2D
    {
        public Circle(double r) 
        {
            R = r;
        }
        public double R { get; set; }
        public override double CalcArea()
        {
            return Math.PI*R ;
        }

        public override string ToString()
        {
            return String.Format("Kruh ( r={0} )", R);
        }
        public override string Draw()
        {
            return ToString();
        }
    }
}
