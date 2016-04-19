using System;

namespace _07.Sum_of_5_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e;

            Int32.TryParse(Console.ReadLine(), out a);
            Int32.TryParse(Console.ReadLine(), out b);
            Int32.TryParse(Console.ReadLine(), out c);
            Int32.TryParse(Console.ReadLine(), out d);
            Int32.TryParse(Console.ReadLine(), out e);

            if (a <= -1000 || a >= 1000 ||
                b <= -1000 || b >= 1000 ||
                c <= -1000 || c >= 1000 ||
                d <= -1000 || d >= 1000 ||
                e <= -1000 || e >= 1000 )
                return;

            Console.WriteLine(a + b + c + d + e);
            Console.ReadLine();
        }
    }
}
