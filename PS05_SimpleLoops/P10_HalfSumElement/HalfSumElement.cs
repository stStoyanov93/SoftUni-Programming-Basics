using System;

namespace P10_HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());
            int max = -1000000000;
            int sum = 0;

            for (int i = 0; i < controlNumber; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }

            sum -= max;

            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + sum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + Math.Abs(sum - max));
            }
        }
    }
}
