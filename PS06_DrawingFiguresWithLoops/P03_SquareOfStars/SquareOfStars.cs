using System;

namespace P03_SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write('*');

                for (int j = 1; j < n; j++)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
        }
    }
}
