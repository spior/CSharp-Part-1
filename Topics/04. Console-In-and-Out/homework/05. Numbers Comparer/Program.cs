using System;

namespace _05.Numbers_Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B;

            Double.TryParse(Console.ReadLine(), out A);
            Double.TryParse(Console.ReadLine(), out B);

            Console.WriteLine(Math.Max(A, B));
        }
    }
}
