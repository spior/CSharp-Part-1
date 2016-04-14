using System;

namespace _13.Modify_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            UInt64 N;
            sbyte P;
            sbyte v;
            UInt64.TryParse(Console.ReadLine(), out N);
            SByte.TryParse(Console.ReadLine(), out P);
            SByte.TryParse(Console.ReadLine(), out v);

            if(P > 64 || v > 1)
            {
                Console.WriteLine("lol");
                return;
            }

            if(v==0)
                N &= (byte)~(1 << P);
            else
                N |= (byte)(1 << P);

            Console.WriteLine(N);
        }
    }
}
