using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_step.Class_Works
{
    internal class CW6
    {
        public static void WriteArea(Shape shape)
        {
            if (shape is Triangle)
            {
                (shape as Triangle)?.CalculateArea();
            }
            else if (shape is Martkutxedi)
            {
                (shape as Martkutxedi)?.CalculateArea();
            }
            else
            {
                (shape as Circle)?.CalculateArea();
            }
        }


      public  class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine(" Draw some shape ...");
            }

            public virtual void CalculateArea()
            {
                Console.WriteLine("THis should calculate area");
            }
        }


        public class Triangle : Shape
        {
            public Triangle(double height, double bottom)
            {
                Height = height;
                Bottom = bottom;
            }
            double Height { get; set; }
            double Bottom { get; set; }


            public override void Draw()
            {
                Console.WriteLine(" Draw Triangle ...");
            }

            public override void CalculateArea()
            {
                Console.WriteLine($"Area of the Triangle with height={Height} bottom={Bottom}= {Height * Bottom / 2}");
            }
        }

        public class Martkutxedi : Shape
        {
            public Martkutxedi(double a, double b)
            {
                A = a;
                B = b;
            }
            double A { get; set; }
            double B { get; set; }



            public override void Draw()
            {
                Console.WriteLine(" Draw oxkutxed ...");
            }

            public override void CalculateArea()
            {
                Console.WriteLine($"Area of the oxkutxed with sides a={A} b={B} ={A * B}");
            }
        }

        public class Circle : Shape
        {
            public Circle(double r)
            {
                R = r;
            }
            double R { get; set; }

            public override void Draw()
            {
                Console.WriteLine(" Draw Cirlce ...");
            }

            public override void CalculateArea()
            {
                Console.WriteLine($"Area of the Cirlce with radius={R} ={R * R * 3.14}");
            }
        }
    }
}
