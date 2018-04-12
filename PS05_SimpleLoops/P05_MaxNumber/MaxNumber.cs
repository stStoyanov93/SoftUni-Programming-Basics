using System;

namespace P05_MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());

            int max = int.MinValue;

            for (int i = 0; i < controlNumber; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine(max);
        }
    }
}
