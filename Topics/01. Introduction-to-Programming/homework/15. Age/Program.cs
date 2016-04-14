using System;

namespace _15.Age
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime Birth = DateTime.Parse(Console.ReadLine());

            if (Birth.Year > 2017)
            {
                Console.WriteLine("Date later than 2017.");
                Console.ReadLine();
                return;
            }

            DateTime Today = DateTime.Now;

            int Age = Today.Year - Birth.Year;

            Console.WriteLine(Age);
            Console.WriteLine(Age + 10);
            Console.ReadLine();
        }
    }
}
