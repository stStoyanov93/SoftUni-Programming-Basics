﻿using System;

namespace P08_MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            switch (input)
            {
                case "m":;
                    break;
                case "mm": number = number / 1000;
                    break;
                case "cm": number = number / 100;
                    break;
                case "mi": number = number / 0.000621371192;
                    break;
                case "in": number = number / 39.3700787;
                    break;
                case "km": number = number / 0.001;
                    break;
                case "ft": number = number / 3.2808399;
                    break;
                case "yd": number = number / 1.0936133;
                    break;             
            }

            switch (output)
            {
                case "m": number = number * 1;
                    break;
                case "mm": number = number * 1000;
                    break;
                case "cm": number = number * 100;
                    break;
                case "mi": number = number * 0.000621371192;
                    break;
                case "in": number = number * 39.3700787;
                    break;
                case "km": number = number * 0.001;
                    break;
                case "ft": number = number * 3.2808399;
                    break;
                case "yd": number = number * 1.0936133;
                    break;
            }

            Console.WriteLine($"{number} {output}");
        }
    }
}
