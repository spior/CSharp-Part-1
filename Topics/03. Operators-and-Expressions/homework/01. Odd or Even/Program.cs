using System;

namespace _01.Odd_or_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Int32.TryParse(Console.ReadLine(), out a);

            if (a % 2 == 0)
                Console.WriteLine("even {0}", a);
            else
                Console.WriteLine("odd {0}", a);
        }
    }
}