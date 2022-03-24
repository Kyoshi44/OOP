using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_cv7
{
    class Circle : Object2D
    {
        public Circle(double r)
        {
            R = r;
        }
        public double R { get; set; }
        public override double Area()
        {
            return Math.PI * R;
        }

        public override string ToString()
        {
            return String.Format("Kruh ( r={0} )", R);
        }
        /*public override string Draw()
        {
            return ToString();
        }*/ 
    }
}
