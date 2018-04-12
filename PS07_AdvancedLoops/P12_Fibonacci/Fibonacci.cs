using System;

namespace P12_Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstFibNumber = 1;
            int secondFibNumber = 1;

            for (var i = 0; i < n - 1; i++)
            {
                var nextFibNumber = firstFibNumber + secondFibNumber;
                firstFibNumber = secondFibNumber;
                secondFibNumber = nextFibNumber;
            }

            Console.WriteLine(secondFibNumber);
        }
    }
}
