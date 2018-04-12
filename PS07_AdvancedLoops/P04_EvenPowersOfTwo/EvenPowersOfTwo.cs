using System;

namespace P04_EvenPowersOfTwo
{
    class EvenPowersOfTwo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 1;

            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(currentNumber);
                currentNumber *= 4;
            }
        }
    }
}
