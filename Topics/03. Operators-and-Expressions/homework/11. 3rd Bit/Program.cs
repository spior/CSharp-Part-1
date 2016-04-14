using System;

namespace _11._3rd_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = 0;
            UInt32.TryParse(Console.ReadLine(), out N);

            uint bit = (N & (1 << 3 - 1));

            Console.WriteLine(bit != 0 ? 1 : 0);
        }
    }
}
