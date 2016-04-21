using System;

namespace _05.Biggest_of_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            Double.TryParse(Console.ReadLine(), out A);
            Double.TryParse(Console.ReadLine(), out B);
            Double.TryParse(Console.ReadLine(), out C);

            Console.WriteLine(Math.Max(A, Math.Max(B, C)));
        }
    }
}
