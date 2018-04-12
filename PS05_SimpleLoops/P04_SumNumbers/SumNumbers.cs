using System;

namespace P04_SumNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < controlNumber; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
