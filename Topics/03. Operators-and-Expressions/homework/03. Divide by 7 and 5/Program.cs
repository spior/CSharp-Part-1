using System;

namespace _03.Divide_by_7_and_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Int32.TryParse(Console.ReadLine(), out a);

            bool fizzbuzz = false;

            if (a % 7 == 0 && a % 5 == 0)
                fizzbuzz = true;

            Console.WriteLine("{0} {1}", fizzbuzz.ToString().ToLower(), a);
        }
    }
}