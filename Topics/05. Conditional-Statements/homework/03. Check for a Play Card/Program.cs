﻿using System;

namespace _03.Check_for_a_Play_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            string card = Console.ReadLine();

            if (card == "2" ||
                card == "3" ||
                card == "4" ||
                card == "5" ||
                card == "6" ||
                card == "7" ||
                card == "8" ||
                card == "9" ||
                card == "10" ||
                card == "J" ||
                card == "Q" ||
                card == "K" ||
                card == "A")
                Console.WriteLine("yes {0}", card);
            else
                Console.WriteLine("no {0}", card);
        }
    }
}
