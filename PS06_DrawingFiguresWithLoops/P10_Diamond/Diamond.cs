using System;

namespace P10_Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int leftAndRightDashes = (n - 1) / 2;
            int midDashes = n - 2 * leftAndRightDashes - 2;
            int stars = 1;
            int starPlus = 2;

            for (int row = 0; row < (n + 1) / 2; row++)
            {
                if (row == 0 & (n % 2 == 0))
                {
                    Console.Write(new string('-', leftAndRightDashes));
                    Console.Write(new string('*', starPlus));
                    Console.Write(new string('-', leftAndRightDashes));
                }
                else if (row == 0)
                {
                    Console.Write(new string('-', leftAndRightDashes));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', leftAndRightDashes));
                }

                if (row != 0)
                {
                    Console.Write("{0}{1}{2}{1}{0}",
                        new string('-', leftAndRightDashes),
                        new string('*', stars),
                        new string('-', midDashes));
                }

                Console.WriteLine();

                leftAndRightDashes--;
                midDashes += 2;
            }

            int bottomLeftAndRightDashes = 1;
            int bottomMidDashes = n - 4;

            for (int i = ((n + 1) / 2) - 1; i >= 1; i--)
            {
                if (i != 1)
                {
                    Console.Write("{0}{1}{2}{1}{0}",
                       new string('-', bottomLeftAndRightDashes),
                       new string('*', stars),
                       new string('-', bottomMidDashes));
                }

                if (i == 1 & (n % 2 == 0))
                {
                    Console.Write(new string('-', bottomLeftAndRightDashes));
                    Console.Write(new string('*', starPlus));
                    Console.Write(new string('-', bottomLeftAndRightDashes));
                }
                else if (i == 1)
                {
                    Console.Write(new string('-', bottomLeftAndRightDashes));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', bottomLeftAndRightDashes));
                }

                Console.WriteLine();

                bottomLeftAndRightDashes++;
                bottomMidDashes -= 2;
            }
        }
    }
}
