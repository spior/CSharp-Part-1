using System;

namespace _08.Prime_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Int32.TryParse(Console.ReadLine(), out n);

            if (n > 100)
            {
                Console.WriteLine("false");
                return;
            }
            
            if (n == 2 || n == 3)
            {
                Console.WriteLine("true");
                return;
            }
            else if (n % 2 == 0 || n % 3 == 0 || n == 1)
            {
                Console.WriteLine("false");
                return;
            }

            int i = 5, w = 2;

            while (i * i <= n)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("false");
                    return;
                }
                i += w;
                w = 6 - w;
            }
            Console.WriteLine("true");
        }
    }
}
