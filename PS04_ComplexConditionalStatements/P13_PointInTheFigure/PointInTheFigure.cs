using System;

namespace P13_PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool isInside = (x > 0 && x < h * 3) && (y > 0 && y < h)
                           || (x > h && x < h * 2) && (y > 0 && y < h * 4);
            bool isOutside = ((x < 0 || x > h * 3) && y <= h)
                                || ((x < h || x > h * 2) && y > h)
                                || (y < 0 || y > h * 4);

            if (isInside)
            {
                Console.WriteLine("inside");
            }
            else if (isOutside)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
