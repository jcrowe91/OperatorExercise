using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 10;
            double c = 22;
            double d = 15;
            Console.WriteLine($"Addition {a + b}");
            Console.WriteLine($"Subtraction {a - b}");
            Console.WriteLine($"Multiplication {a * b}");
            Console.WriteLine($"Division {a / b}");
            Console.WriteLine($"Mod {c % d}");

            Console.WriteLine("-------------------------------------------------------------");

            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine($"The area of your circle is {area}");

        }

        public static double AreaOfCircle(double radius) 
        {            
            double area = Math.PI * Math.Pow(radius, 2);
            return area;       
        }
    
    }   

}
