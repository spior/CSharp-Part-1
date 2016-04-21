using System;

namespace _06.Biggest_of_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, D, E;

            Double.TryParse(Console.ReadLine(), out A);
            Double.TryParse(Console.ReadLine(), out B);
            Double.TryParse(Console.ReadLine(), out C);
            Double.TryParse(Console.ReadLine(), out D);
            Double.TryParse(Console.ReadLine(), out E);

            Console.WriteLine(Math.Max(A, Math.Max(B, Math.Max(C, Math.Max(D, E)))));
        }
    }
}
