using System;

namespace _09.Sum_of_n_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            int N;

            Int32.TryParse(Console.ReadLine(), out N);

            if (N < 1 || N > 1000) return;

            for (int i = 0; i < N; i++)
            {
                double temp;
                Double.TryParse(Console.ReadLine(), out temp);
                if (N < 1 || N > 1000) return;
                sum += temp;
            }

            Console.WriteLine(sum);
        }
    }
}
