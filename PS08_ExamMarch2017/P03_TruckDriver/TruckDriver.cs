using System;

namespace P03_TruckDriver
{
    class TruckDriver
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double sum;
            double moneyPerKM;


            if (kmPerMonth > 10000)
            {
                double taxes = ((1.45 * kmPerMonth) * 4) * 0.1;
                sum = ((1.45 * kmPerMonth) * 4) - taxes;
            }
            else
            {
                if (season == "Autumn" || season == "Spring")
                {
                    if (kmPerMonth <= 5000)
                    {
                        moneyPerKM = 0.75;
                    }
                    else
                    {
                        moneyPerKM = 0.95;
                    }
                }
                else if (season == "Summer")
                {
                    if (kmPerMonth <= 5000)
                    {
                        moneyPerKM = 0.90;
                    }
                    else
                    {
                        moneyPerKM = 1.10;
                    }
                }
                else
                {
                    if (kmPerMonth <= 5000)
                    {
                        moneyPerKM = 1.05;
                    }
                    else
                    {
                        moneyPerKM = 1.25;
                    }
                }

                double taxes = ((moneyPerKM * kmPerMonth) * 4) * 0.1;
                sum = (moneyPerKM * kmPerMonth) * 4 - taxes;
            }

            Console.WriteLine("{0:F2}", sum);
        }
    }
}
