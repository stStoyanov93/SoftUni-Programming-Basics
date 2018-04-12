using System;

namespace P01_RectangleOfTenXTenStars
{
    class RectangleOfTenXTenStars
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('*', 10));
            }
        }
    }
}
