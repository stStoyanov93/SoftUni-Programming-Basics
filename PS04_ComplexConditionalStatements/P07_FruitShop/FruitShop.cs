using System;

namespace P07_FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
           const decimal bananaPrice = 2.50M;
           const decimal applePrice = 1.20M;
           const decimal orangePrice = 0.85M;
           const decimal grapefruitPrice = 1.45M;
           const decimal kiwiPrice = 2.70M;
           const decimal pineapplePrice = 5.50M;
           const decimal grapesPrice = 3.85M;

            string fruitType = Console.ReadLine().ToLower();
            string dayOfTheWeek = Console.ReadLine().ToLower();
            decimal quantity = decimal.Parse(Console.ReadLine());

            bool isAWorkDay = (dayOfTheWeek == "monday") || (dayOfTheWeek == "tuesday") || (dayOfTheWeek == "wednesday") ||
                                (dayOfTheWeek == "thursday") || (dayOfTheWeek == "friday");

            bool isAWeekendDay = (dayOfTheWeek == "saturday") || (dayOfTheWeek == "sunday");


            decimal productPrice = -1;

            if (isAWorkDay)
            {
                switch (fruitType)
                {
                    case "banana":
                        productPrice = bananaPrice;
                        break;
                    case "apple":
                        productPrice = applePrice;
                        break;
                    case "orange":
                        productPrice = orangePrice;
                        break;
                    case "grapefruit":
                        productPrice = grapefruitPrice;
                        break;
                    case "kiwi":
                        productPrice = kiwiPrice;
                        break;
                    case "pineapple":
                        productPrice = pineapplePrice;
                        break;
                    case "grapes":
                        productPrice = grapesPrice;
                        break;
                }
            }
            else if (isAWeekendDay)
            {
                switch (fruitType)
                {
                    case "banana":
                        productPrice = bananaPrice + 0.20M;
                        break;
                    case "apple":
                        productPrice = applePrice + 0.05M;
                        break;
                    case "orange":
                        productPrice = orangePrice + 0.05M;
                        break;
                    case "grapefruit":
                        productPrice = grapefruitPrice + 0.15M;
                        break;
                    case "kiwi":
                        productPrice = kiwiPrice + 0.30M;
                        break;
                    case "pineapple":
                        productPrice = pineapplePrice + 0.10M;
                        break;
                    case "grapes":
                        productPrice = grapesPrice + 0.35M;
                        break;
                }
            }
           

            if (productPrice != -1)
            {
                Console.WriteLine("{0:f2}", quantity * productPrice);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
