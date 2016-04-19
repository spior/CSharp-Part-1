using System;

namespace _01.Sum_of_3_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            Int32.TryParse(Console.ReadLine(), out c);

            if (a < -1000 || a > 1000 ||
                b < -1000 || b > 1000 ||
                c < -1000 || c > 1000)
                return;

            Console.WriteLine(a + b + c);
        }
    }
}
