﻿using System;

namespace P02_RectangleOfNTimesNStars
{
    class RectangleOfNTimesNStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('*', n));
            }
        }
    }
}
