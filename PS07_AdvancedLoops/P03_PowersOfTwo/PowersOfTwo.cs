﻿using System;

namespace P03_PowersOfTwo
{
    class PowersOfTwo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 1;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(currentNumber);
                currentNumber *= 2;
            }
        }
    }
}
