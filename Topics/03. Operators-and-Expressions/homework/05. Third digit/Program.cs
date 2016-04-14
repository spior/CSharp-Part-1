using System;

namespace _05.Third_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = 0;
            UInt32.TryParse(Console.ReadLine(), out N);

            if (N < 100)
                Console.WriteLine("false 0");
            else
            {
                uint digit = (N / (uint)Math.Pow(10, 3 - 1)) % 10;

                if (digit == 7)
                    Console.WriteLine("true");
                else
                    Console.WriteLine("false {0}", digit);
            }
        }
    }
}
