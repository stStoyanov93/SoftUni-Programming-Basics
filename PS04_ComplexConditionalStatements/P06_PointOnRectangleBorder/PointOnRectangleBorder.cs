using System;

namespace P06_PointOnRectangleBorder
{
    class PointOnRectangleBorder
    {
        static void Main(string[] args)
        {
            double x1 = Double.Parse(Console.ReadLine());
            double y1 = Double.Parse(Console.ReadLine());

            double x2 = Double.Parse(Console.ReadLine());
            double y2 = Double.Parse(Console.ReadLine());

            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());

            var isOnLeftSide = (x == x1) && (y >= y1) && (y <= y2);
            var isOnRightSide = (x == x2) && (y >= y1) && (y <= y2);
            var isOnUpSide = (y == y1) && (x >= x1) && (x <= x2);
            var isOnDownSide = (y == y2) && (x >= x1) && (x <= x2);

            if (isOnLeftSide || isOnRightSide || isOnUpSide || isOnDownSide)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
