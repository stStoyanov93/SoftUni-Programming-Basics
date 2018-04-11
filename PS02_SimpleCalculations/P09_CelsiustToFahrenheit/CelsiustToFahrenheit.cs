using System;

namespace P09_CelsiustToFahrenheit
{
    class CelsiustToFahrenheit
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double farenheit = (celsius * 9) / 5 + 32;

            Console.WriteLine(farenheit);
        }
    }
}
