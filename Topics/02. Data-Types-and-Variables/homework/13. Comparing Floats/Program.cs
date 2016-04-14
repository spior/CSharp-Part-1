using System;

namespace _13.Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, eps = 0.000001;

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());

            Console.WriteLine(Math.Abs(a - b) < eps);
        }
    }
}
