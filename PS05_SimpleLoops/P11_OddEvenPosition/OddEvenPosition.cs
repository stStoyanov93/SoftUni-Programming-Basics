using System;

namespace P11_OddEvenPosition
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());

            double oddSum = 0.0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;

            double evenSum = 0.0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;

            for (int i = 1; i <= controlNumber; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;

                    if (evenMax < num)
                    {
                        evenMax = num;
                    }

                    if (evenMin > num)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;

                    if (oddMax < num)
                    {
                        oddMax = num;
                    }

                    if (oddMin > num)
                    {
                        oddMin = num;
                    }
                }
            }

            if (controlNumber == 0)
            {
                Console.WriteLine("OddSum=0, OddMin=No, OddMax=No, " +
                    "EvenSum=0, EvenMin=No, EvenMax=No");
            }
            else if (controlNumber == 1)
            {
                Console.WriteLine($"OddSum={oddSum}, OddMin={oddMin}, OddMax={oddMax}, " +
                    $"EvenSum=0, EvenMin=No, EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum}, OddMin={oddMin}, OddMax={oddMax}, " +
                    $"EvenSum={evenSum}, EvenMin={evenMin}, EvenMax={evenMax}");
            }
        }
    }
}
