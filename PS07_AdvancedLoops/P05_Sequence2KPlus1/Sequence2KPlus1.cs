using System;

namespace P05_Sequence2KPlus1
{
    class Sequence2KPlus1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNumber = 1;

            for (int i = 0; currentNumber <= n; i++)
            {
                Console.WriteLine(currentNumber);
                currentNumber = currentNumber * 2 + 1;
            }
        }
    }
}
