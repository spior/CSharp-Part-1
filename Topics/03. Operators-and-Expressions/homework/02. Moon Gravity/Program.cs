using System;

namespace _02.Moon_Gravity
{
    class Program
    {
        static void Main(string[] args)
        {
            double W = 0;
            Double.TryParse(Console.ReadLine(), out W);

            double mW = W * 17 / 100;

            Console.WriteLine(mW.ToString("0.000"));
        }
    }
}