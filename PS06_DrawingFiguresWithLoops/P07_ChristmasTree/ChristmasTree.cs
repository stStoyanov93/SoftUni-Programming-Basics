using System;

namespace P07_ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string(' ', n + 1));
            Console.WriteLine("|");

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}{1}{2}{3}{2}{1}",
                    new string(' ', n - i),
                    new string('*', i),
                    new string(' ', 1),
                    new string('|', 1));

                Console.WriteLine();
            }
        }
    }
}
