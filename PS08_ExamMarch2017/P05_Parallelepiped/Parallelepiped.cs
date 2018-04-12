using System;

namespace P05_Parallelepiped
{
    class Parallelepiped
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int h = n * 4 + 4;

            Console.WriteLine("{0}{1}{0}{2}",
                new string('+', 1),
                new string('~', n - 2),
                new string('.', (3 * n + 1) - ((n - 2) + 2)));

            for (int i = 0; i < h / 2 - 1; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{2}{4}", new string('|', 1),
                   new string('.', i),
                   new string('\\', 1),
                   new string('~', n - 2),
                   new string('.', ((3 * n + 1) - ((n - 2) + 2)) - (i + 1)));
            }

            for (int i = 0; i < h / 2 - 1; i++)
            {
                Console.WriteLine("{1}{2}{4}{0}{3}{0}", new string('|', 1),
                   new string('.', i),
                   new string('\\', 1),
                   new string('~', n - 2),
                   new string('.', ((3 * n + 1) - ((n - 2) + 2)) - (i + 1)));
            }

            Console.WriteLine("{2}{0}{1}{0}",
                new string('+', 1),
                new string('~', n - 2),
                new string('.', (3 * n + 1) - ((n - 2) + 2)));
        }
    }
}
