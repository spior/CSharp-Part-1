using System;
namespace _06.Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;

            Double.TryParse(Console.ReadLine(), out a);
            Double.TryParse(Console.ReadLine(), out b);
            Double.TryParse(Console.ReadLine(), out c);

            double D = Math.Pow(b, 2) - 4 * a * c;

            if (D < 0)
            {
                Console.WriteLine("no real roots");
                return;
            }

            double x1 = (-b - Math.Sqrt(D)) / (2*a);
            double x2 = (-b + Math.Sqrt(D)) / (2*a);

            Console.WriteLine(x1.ToString("0.00"));
            if (x1 == x2) return;
            Console.WriteLine(x2.ToString("0.00"));
        }
    }
}
