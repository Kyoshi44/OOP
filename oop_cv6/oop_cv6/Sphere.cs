using System;
using System.Collections.Generic;
using System.Text;

namespace oop_cv6
{
    internal class Sphere : Object3D
    {
        public double R { get; set;}
        public Sphere(double r) 
        {
            R = r;
        }
        public override double CalcSurface()
        {
            return 4*Math.PI*R;
        }

        public override double CalcVolume()
        {
            return 4/3*Math.PI*Math.Pow(R,3);
        }

        public override string ToString()
        {
            return String.Format("Koule ( r={0} )", R);
        }
        public override string Draw()
        {
            return ToString();
        }
    }
}
