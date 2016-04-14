using System;

namespace _09.Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, h;
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out h);

            if( a < -500 || a > 500 ||
                b < -500 || b > 500 ||
                h < -500 || h > 500 )
            {
                Console.WriteLine("nope");
                return;
            }

            Console.WriteLine((((a + b) / 2) * h).ToString("0.0000000"));
        }
    }
}
