using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_cv7
{
     abstract class Object2D : I2D, IComparable
    {
        public abstract double Area();

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Object2D o2d = obj as Object2D;
            if (o2d != null)
                return this.Area().CompareTo(o2d.Area());
            else
                throw new ArgumentException("Object is not a 2D object");
        }
    }
    
}
