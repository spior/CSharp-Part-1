using System;

namespace _04.Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            Double.TryParse(Console.ReadLine(), out A);
            Double.TryParse(Console.ReadLine(), out B);
            Double.TryParse(Console.ReadLine(), out C);

            if((A < 0 && B < 0 && C > 0) || (B < 0 && C < 0 && A > 0) || (A < 0 && C < 0 && B > 0))
                Console.WriteLine("+");
            else if (A < 0 || B < 0 || C < 0)
                Console.WriteLine("-");
            else if (A == 0 || B == 0 || C == 0)
                Console.WriteLine("0");
            else
                Console.WriteLine("+");
        }
    }
}
