using System;

namespace _11.Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;

            Int32.TryParse(Console.ReadLine(), out N);
            Int32.TryParse(Console.ReadLine(), out M);

            if (N < 0 || N > 2000) return;
            if (M < 0 || M > 2000) return;

            int num = 0;
            for (int i = N + 1; i <= M; i++)
                if (i % 5 == 0)
                    num++;

            Console.WriteLine(num);
        }
    }
}
