using System;

namespace P08_TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            double baseSide = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = baseSide * height / 2;

            Console.WriteLine($"Triangle area = {area}");
        }
    }
}
