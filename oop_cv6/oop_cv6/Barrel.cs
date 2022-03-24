using System;
using System.Collections.Generic;
using System.Text;

namespace oop_cv6
{
    internal class Barrel : Object3D
    {
        public Circle Base { get; set;}
        public Barrel(double r, double h) 
        {
            H = h;
            Base = new Circle(r);
        }
        public double H { get; set; }
        public override double CalcSurface()
        {
            return 2*Base.R*Math.PI*(Base.R+H);
        }

        public override double CalcVolume()
        {
            return Math.PI*Math.Pow(Base.R,2)*H;
        }

        public override string ToString()
        {
            return String.Format("Valec ( r = {0}, h= {1})", Base.R, H);
        }
        public override string Draw()
        {
            return ToString();
        }
    }
}
