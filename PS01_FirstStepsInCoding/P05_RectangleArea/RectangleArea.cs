using System;

namespace P05_RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());

            Console.WriteLine(sideA * sideB);
        }
    }
}
