using System;

namespace P07_GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            while (secondNumber != 0)
            {
                int oldSecondNumber = secondNumber;
                secondNumber = firstNumber % secondNumber;
                firstNumber = oldSecondNumber;
            }

            Console.WriteLine(firstNumber);
        }
    }
}
