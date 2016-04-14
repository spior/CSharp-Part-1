using System;

namespace _09.Print_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1003; i++)
                Console.WriteLine(i % 2 == 0 ? i : -i);
            Console.ReadLine();
        }
    }
}
