﻿using System;

namespace P10_RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degrees = (radians * 180) / Math.PI;

            Console.WriteLine(Math.Round(degrees));
        }
    }
}
