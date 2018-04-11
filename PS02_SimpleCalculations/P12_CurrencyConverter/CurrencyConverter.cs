using System;

namespace P12_CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            const double dollarExchangeRate = 1.79549;
            const double euroExchangeRate = 1.95583;
            const double poundExchangeRate = 2.53405;

            double input = double.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();

            double convertedToBGN = 0;


            switch (inputCurrency.ToLower())
            {
                case "bgn":
                    convertedToBGN = input;
                    break;
                case "usd":
                    convertedToBGN = input * dollarExchangeRate;
                    break;
                case "eur":
                    convertedToBGN = input * euroExchangeRate;
                    break;
                case "gbp":
                    convertedToBGN = input * poundExchangeRate;
                    break;
            }


            switch (outputCurrency.ToLower())
            {
                case "bgn":
                    Console.WriteLine(Math.Round(convertedToBGN, 2) + " BGN");
                    break;
                case "usd":
                    Console.WriteLine(Math.Round(convertedToBGN / dollarExchangeRate, 2) + " USD");
                    break;
                case "eur":
                    Console.WriteLine(Math.Round(convertedToBGN / euroExchangeRate, 2) + " EUR");
                    break;
                case "gbp":
                    Console.WriteLine(Math.Round(convertedToBGN / poundExchangeRate, 2) + " GBP");
                    break;
            }
        }
    }
}
