using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_cv7
{
    class Extremes
    {
        public static T Biggest<T>(T[] array) where T : IComparable 
        {
            T maxValue = array.Max();
            return maxValue;
        }

        public static T Smallest<T>(T[] array) where T : IComparable
        {
            T minValue = array.Min();
            return minValue;
        }
    }
}
