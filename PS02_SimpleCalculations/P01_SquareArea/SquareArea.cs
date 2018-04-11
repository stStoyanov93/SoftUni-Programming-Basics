using System;

namespace P01_SquareArea
{
    class SquareArea
    {
        static void Main(string[] args)
        {
            int squareSide = int.Parse(Console.ReadLine());
            int area = squareSide * squareSide;

            Console.WriteLine($"Square = {area}");
        }
    }
}
