using System;

namespace P11_USDtoBGN
{
    class USDtoBGN
    {
        static void Main(string[] args)
        {
            const double dollarExchangeRate = 1.79549;

            double usd = double.Parse(Console.ReadLine());
            double bg = usd * dollarExchangeRate;

            Console.WriteLine(Math.Round(bg, 2));
        }
    }
}
