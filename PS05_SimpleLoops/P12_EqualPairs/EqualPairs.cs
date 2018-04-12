using System;

namespace P12_EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());

            double oldSum = 0;
            double sum = 0;
            double difference = 0;
            double maxDifference = 0;

            for (int i = 0; i < controlNumber; i++)
            {
                double firstNumber = double.Parse(Console.ReadLine());
                double secondNumber = double.Parse(Console.ReadLine());

                if (i == 0)
                {
                    oldSum = firstNumber + secondNumber;
                }
                else
                {
                    sum = firstNumber + secondNumber;
                    difference = Math.Abs(sum - oldSum);

                    if (difference > maxDifference)
                    {
                        maxDifference = difference;
                    }

                    oldSum = sum;
                }
            }

            if (maxDifference == 0)
            {
                Console.WriteLine($"Yes, value ={oldSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff ={maxDifference}");
            }
        }
    }
}
