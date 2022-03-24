using System;
using System.Collections.Generic;
using System.Text;

namespace oop_cv6
{
    internal abstract class Object3D : GrObject
    {
        public abstract double CalcSurface();
        public abstract double CalcVolume();

    }
}
