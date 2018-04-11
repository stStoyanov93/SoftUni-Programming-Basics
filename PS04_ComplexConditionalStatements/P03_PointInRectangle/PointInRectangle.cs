using System;

namespace P03_PointInRectangle
{
    class PointInRectangle
    {
        static void Main(string[] args)
        {
            double x1 = Double.Parse(Console.ReadLine());
            double y1 = Double.Parse(Console.ReadLine());

            double x2 = Double.Parse(Console.ReadLine());
            double y2 = Double.Parse(Console.ReadLine());

            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());

            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
