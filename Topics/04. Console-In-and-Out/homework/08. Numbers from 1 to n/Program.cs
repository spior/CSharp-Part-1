using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Numbers_from_1_to_n
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Int32.TryParse(Console.ReadLine(), out N);

            if (N < 1 || N > 1000) return;

            for (int i = 1; i <= N; i++)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
