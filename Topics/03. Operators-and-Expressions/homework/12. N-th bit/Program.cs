using System;

namespace _12.N_th_bit
{
    class Program
    {
        static void Main(string[] args)
        {
            uint P;
            sbyte N;
            UInt32.TryParse(Console.ReadLine(), out P);
            SByte.TryParse(Console.ReadLine(), out N);

            if(P > Math.Pow(2, 55) || N >= 55)
            {
                Console.WriteLine("nah");
                return;
            }

            bool bit = (P & (1 << N)) != 0;

            Console.WriteLine(bit ? 1 : 0);
        }
    }
}
