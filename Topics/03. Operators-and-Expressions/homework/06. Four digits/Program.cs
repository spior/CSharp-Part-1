using System;

namespace _06.Four_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = 0;
            UInt32.TryParse(Console.ReadLine(), out N);

            if (N < 1000)
            {
                Console.WriteLine("not 4 digits tho");
                return;
            }

            uint fidigit = (N / (uint)Math.Pow(10, 3)) % 10;
            uint sedigit = (N / (uint)Math.Pow(10, 2)) % 10;
            uint thdigit = (N / (uint)Math.Pow(10, 1)) % 10;
            uint fodigit = (N / (uint)Math.Pow(10, 0)) % 10;

            Console.WriteLine(fidigit + sedigit + thdigit + fodigit);
            Console.WriteLine(fodigit * 1000 + thdigit * 100 + sedigit * 10 + fidigit);
            Console.WriteLine(fodigit * 1000 + fidigit * 100 + sedigit * 10 + thdigit);
            Console.WriteLine(fidigit * 1000 + thdigit * 100 + sedigit * 10 + fodigit);
        }
    }
}
