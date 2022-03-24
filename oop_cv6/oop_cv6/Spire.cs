using System;
using System.Collections.Generic;
using System.Text;

namespace oop_cv6
{
    internal class Spire : Object3D
    {
        public Spire(double a, double b, double v) 
        {
           
            V = v;
            podstava = new Rectangle(a,b);
        }
        
        public double V { get; private set; }
        public Rectangle podstava
        { get; set; }
        public override double CalcSurface()
        {
            return podstava.CalcArea() +(podstava.A*Math.Sqrt(V*V+podstava.B*podstava.B/4))
                +(podstava.B*Math.Sqrt(V*V+podstava.A*podstava.A/4));
        }

        public override double CalcVolume()
        {
            return (podstava.CalcArea()* V) * 1/3;
        }

        public override string ToString()
        {
            return String.Format("Jehlan ( a = {0}, b= {1}, v= {2} )", podstava.A, podstava.B, V);
        }
        public override string Draw()
        {
            return ToString();
        }
    }
}
