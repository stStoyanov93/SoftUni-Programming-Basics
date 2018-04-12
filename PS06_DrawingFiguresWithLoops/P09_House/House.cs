using System;

namespace P09_House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stars = 1;

            if (n % 2 == 0)
            {
                stars = 2;
            }

            for (int roof = 1; roof <= (n + 1) / 2; roof++)
            {
                int padding = (n - stars) / 2;

                Console.WriteLine("{0}{1}{0}", new string('-', padding),
                    new string('*', stars));

                stars += 2;
            }

            for (int body = 1; body <= n / 2; body++)
            {
                int starsBody = n - 2;

                Console.WriteLine("{0}{1}{0}", new string('|', 1),
                    new string('*', starsBody));
            }
        }
    }
}
