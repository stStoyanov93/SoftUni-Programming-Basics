using System;

namespace P06_MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());

            int min = int.MaxValue;

            for (int i = 0; i < controlNumber; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine(min);
        }
    }
}
