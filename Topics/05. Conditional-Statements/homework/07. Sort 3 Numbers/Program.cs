using System;

namespace _07.Sort_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[3];

            Double.TryParse(Console.ReadLine(), out numbers[0]);
            Double.TryParse(Console.ReadLine(), out numbers[1]);
            Double.TryParse(Console.ReadLine(), out numbers[2]);

            Array.Sort(numbers);

            Console.WriteLine("{0} {1} {2}", numbers[2], numbers[1], numbers[0]);
        }
    }
}
