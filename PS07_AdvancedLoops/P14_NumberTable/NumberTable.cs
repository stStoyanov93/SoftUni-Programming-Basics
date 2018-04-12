using System;

namespace P14_NumberTable
{
    class NumberTable
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());

            for (int row = 0; row < controlNumber; row++)
            {
                for (int col = 0; col < controlNumber; col++)
                {
                    int num = row + col + 1;

                    if (num > controlNumber)
                    {
                        num = (2 * controlNumber) - num;
                    }

                    Console.Write(num + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
