using System;
using System.Collections.Generic;
using System.Text;

namespace oop_cv6
{
    internal class Cuboid : Object3D
    {
        public Rectangle Base { get; set; }
        public Cuboid(double a, double b ,double c) 
        {
            Base = new Rectangle(a, b);
            C = c;
        }
        
        public double C { get; private set; }

        public override double CalcSurface()
        {
            return 2*(Base.CalcArea() + Base.B*C + Base.A*C) ;
        }

        public override double CalcVolume()
        {
            return Base.CalcArea() * C;
        }

        public override string ToString()
        {
            return String.Format("Kvadr ( a = {0}, b= {1}, c= {2} )", Base.A, Base.B, C);
        }
        public override string Draw()
        {
            return ToString();
        }
    }
}
