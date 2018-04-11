using System;

namespace P02_SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double itemPrice = 0.0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    itemPrice = 0.50;
                }
                else if (product == "water")
                {
                    itemPrice = 0.80;
                }
                else if (product == "beer")
                {
                    itemPrice = 1.20;
                }
                else if (product == "sweets")
                {
                    itemPrice = 1.45;
                }
                else if (product == "peanuts")
                {
                    itemPrice = 1.60;
                }
            }
            else if (town == "Plovdiv")
            {
                if (product == "coffee")
                {
                    itemPrice = 0.40;
                }
                else if (product == "water")
                {
                    itemPrice = 0.70;
                }
                else if (product == "beer")
                {
                    itemPrice = 1.15;
                }
                else if (product == "sweets")
                {
                    itemPrice = 1.30;
                }
                else if (product == "peanuts")
                {
                    itemPrice = 1.50;
                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    itemPrice = 0.45;
                }
                else if (product == "water")
                {
                    itemPrice = 0.70;
                }
                else if (product == "beer")
                {
                    itemPrice = 1.10;
                }
                else if (product == "sweets")
                {
                    itemPrice = 1.35;
                }
                else if (product == "peanuts")
                {
                    itemPrice = 1.55;
                }
            }

            double price = itemPrice * quantity;
            Console.WriteLine(price);
        }
    }
}
