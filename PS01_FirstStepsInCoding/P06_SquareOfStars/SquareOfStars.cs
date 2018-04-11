using System;

namespace P06_SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {
            int starsCount = int.Parse(Console.ReadLine());
            int whiteSpace = starsCount - 2;

            //printing the top of the figure
            Console.WriteLine(new string('*', starsCount));

            for (int i = 0; i < starsCount - 2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('*', 1),
                    new string(' ', whiteSpace));
            }

            //printing the bottom of the figure
            Console.WriteLine(new string('*', starsCount));
        }
    }
}
