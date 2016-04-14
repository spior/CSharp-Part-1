using System;

namespace _04.Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            double w, h;
            Double.TryParse(Console.ReadLine(), out w);
            Double.TryParse(Console.ReadLine(), out h);

            double area = w * h;
            double p = 2 * w + 2 * h;

            Console.WriteLine("{0} {1}", area.ToString("0.00"), p.ToString("0.00"));
            Console.ReadLine();
        }
    }
}