﻿using System;

namespace _02.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int score;

            Int32.TryParse(Console.ReadLine(), out score);

            if (score >= 1 && score <= 3)
                score *= 10;
            else if (score >= 4 && score <= 6)
                score *= 100;
            else if (score >= 7 && score <= 9)
                score *= 1000;
            else if(score < 0 || score > 9)
            {
                Console.WriteLine("invalid score");
                return;
            }

            Console.WriteLine(score);
        }
    }
}
