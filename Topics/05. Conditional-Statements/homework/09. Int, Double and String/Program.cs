using System;

namespace _09.Int__Double_and_Strin
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int a;
            double b;
            string c;

            input = Console.ReadLine();
            if (input == "integer")
            {
                Int32.TryParse(Console.ReadLine(), out a);
                a += 1;
                Console.WriteLine(a);
            }
            else if (input == "real")
            {
                Double.TryParse(Console.ReadLine(), out b);
                b += 1.0f;
                Console.WriteLine(b.ToString("0.00"));
            }
            else if (input == "text")
            {
                c = Console.ReadLine();
                c += "*";
                Console.WriteLine(c);
            }
        }
    }
}
