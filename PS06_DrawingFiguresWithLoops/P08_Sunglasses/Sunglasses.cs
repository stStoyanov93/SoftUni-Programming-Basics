using System;

namespace P08_Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //printing the top rim
            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n),
                new string(' ', n),
                new string('*', 2 * n));

            for (int i = 0; i < n - 2; i++)
            {
                if (i == (n - 1) / 2 - 1)
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', 1),
                        new string('/', (n * 2) - 2),
                        new string('|', n));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', 1),
                        new string('/', (n * 2) - 2),
                        new string(' ', n));
                }
            }

            //printing the bottom rim
            Console.WriteLine("{0}{1}{0}", new string('*', 2 * n),
               new string(' ', n),
               new string('*', 2 * n));
        }
    }
}
