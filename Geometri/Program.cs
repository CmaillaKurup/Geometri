using System;

namespace Geometri
{
    class Program
    {
        static void Main()
        {
            Square sq1 = new Square(1);
            Square sq2 = new Square(2);
            Square sq3 = new Square(3);

            Rectangle ra1 = new Rectangle(1,2);
            Rectangle ra2 = new Rectangle(3,4);
            Rectangle ra3 = new Rectangle(5,6);

            Trapezoid tp1 = new Trapezoid(10, 9, 8, 9);
            Trapezoid tp2 = new Trapezoid(3, 4, 5, 6);
            Trapezoid tp3 = new Trapezoid(5, 6, 7, 8);
            
            Parallelogram pg1 = new Parallelogram(1, 2);
            Parallelogram pg2 = new Parallelogram(3, 4);
            Parallelogram pg3 = new Parallelogram(5, 6);


            //Testing Square
            Console.WriteLine("Square Perimeter: " + sq1.Perimeter());
            Console.WriteLine("Square Areal: " + sq1.Areal());
            Console.WriteLine("Square Perimeter: " + sq2.Perimeter());
            Console.WriteLine("Square Areal: " + sq2.Areal());
            Console.WriteLine("Square Perimeter: " + sq3.Perimeter());
            Console.WriteLine("Square Areal: " + sq3.Areal());

            //Testing Rectangle
            Console.WriteLine("Rectangle Perimeter: " + ra1.Perimeter());
            Console.WriteLine("Rectangle Areal: " + ra1.Areal());
            Console.WriteLine("Rectangle Perimeter: " + ra2.Perimeter());
            Console.WriteLine("Rectangle Areal: " + ra2.Areal());
            Console.WriteLine("Rectangle Perimeter: " + ra3.Perimeter());
            Console.WriteLine("Rectangle Areal: " + ra3.Areal());
            
            //Testing Trapezoid
            Console.WriteLine("Trapezoid Perimeter: " + tp1.Perimeter());
            Console.WriteLine("Trapezoid Areal: " + tp1.Areal());
            Console.WriteLine("Trapezoid Perimeter: " + tp2.Perimeter());
            Console.WriteLine("Trapezoid Areal: " + tp2.Areal());
            Console.WriteLine("Trapezoid Perimeter: " + tp3.Perimeter());
            Console.WriteLine("Trapezoid Areal: " + tp3.Areal());
            
            //Testing Parallelogram
            Console.WriteLine("Parallelogram Perimeter: " + pg1.Perimeter());
            Console.WriteLine("Parallelogram Areal: " + pg1.Areal());
            Console.WriteLine("Parallelogram Perimeter: " + pg2.Perimeter());
            Console.WriteLine("Parallelogram Areal: " + pg2.Areal());
            Console.WriteLine("Parallelogram Perimeter: " + pg3.Perimeter());
            Console.WriteLine("Parallelogram Areal: " + pg3.Areal());
        }
    }
}