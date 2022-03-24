using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_cv7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 5, 7, 9 };
            string[] strings = { "car", "motorcycle", "food", "weather" };
            Circle[] circles = { new Circle(6), new Circle(9), new Circle(10) };
            Elipse[] elipses = { new Elipse(2, 7), new Elipse(5, 4), new Elipse(8, 6) };
            Rectangle[] rectangles = { new Rectangle(4, 5), new Rectangle(3, 7), new Rectangle(3, 9) };
            Square[] squares = { new Square(5, 5), new Square(8, 8), new Square(6, 6) };
            Object2D[] objects2d = { new Square(5, 5), new Rectangle(2, 9), new Elipse(3, 4), new Circle(9) };



            Console.WriteLine("Max integer is: " + Extremes.Biggest<int>(numbers));
            Console.WriteLine("Min integer is: " + Extremes.Smallest<int>(numbers));

            Console.WriteLine("Max circle is: " + Extremes.Biggest<Circle>(circles));
            Console.WriteLine("Min circle is: " + Extremes.Smallest<Circle>(circles));

            Console.WriteLine("Max elipse is: " + Extremes.Biggest<Elipse>(elipses));
            Console.WriteLine("Min elipse is: " + Extremes.Smallest<Elipse>(elipses));

            Console.WriteLine("Max rectangle is: " + Extremes.Biggest<Rectangle>(rectangles));
            Console.WriteLine("Min rectangle is: " + Extremes.Smallest<Rectangle>(rectangles));

            Console.WriteLine("Max squares is: " + Extremes.Biggest<Square>(squares));
            Console.WriteLine("Min squares is: " + Extremes.Smallest<Square>(squares));

            Console.WriteLine("Max 2D object is: " + Extremes.Biggest<Object2D>(objects2d));
            Console.WriteLine("Min 2D object is: " + Extremes.Smallest<Object2D>(objects2d));

            // Define the query expression.
            IEnumerable<int> numberQuery =
                from number in numbers
                where number > 4 && number < 8
                select number;

            // Execute the query.
            Console.WriteLine("Numbers in range 4 to 8: ");
            foreach (int i in numberQuery)
            {
                
                Console.Write(i + " ");
            }


            Console.ReadLine();

        }
    }
}
