using System;

namespace _01.Exchange_If_Greater
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B;


            Double.TryParse(Console.ReadLine(), out A);
            Double.TryParse(Console.ReadLine(), out B);

            if (A > B)
            {
                double t = A;
                A = B;
                B = t;
            }

            Console.WriteLine("{0} {1}", A, B);
        }
    }
}
