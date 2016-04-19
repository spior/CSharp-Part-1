using System;

namespace _03.Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;

            Double.TryParse(Console.ReadLine(), out r);

            double area = Math.PI * Math.Pow(r, 2);
            double p = 2 * Math.PI * r;

            Console.WriteLine("{0} {1}", p.ToString("0.00"), area.ToString("0.00"));
            Console.ReadLine();
        }
    }
}
