using System;

namespace oop_cv6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GrObject[] objects = { new Rectangle(4, 5), new Circle(6), new Elipse(2, 7), new Triangle(3, 4, 5),
                                   new Cuboid(6,7,6), new Spire(7,7,8), new Barrel(9,2), new Sphere(10)};


            foreach (GrObject o in objects) 
            {
                Console.WriteLine(o.Draw());
                if (o is Object2D) 
                {
                    Console.WriteLine("Surface of the object is: " + Math.Round(((Object2D)o).CalcArea(), 2));
                }
                else if (o is Object3D)
                {
                    Console.WriteLine("Surface of the object is: " + Math.Round(((Object3D)o).CalcSurface(), 2));
                    Console.WriteLine("Volume of the object is: " + Math.Round(((Object3D)o).CalcVolume(), 2));
                }
            }
            Console.ReadLine();
        }
    }
}
