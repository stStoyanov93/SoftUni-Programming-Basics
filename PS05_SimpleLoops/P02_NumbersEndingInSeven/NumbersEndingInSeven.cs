using System;

namespace P02_NumbersEndingInSeven
{
    class NumbersEndingInSeven
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
