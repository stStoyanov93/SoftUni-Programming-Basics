using System;

namespace P02_Styrofoam
{
    class Styrofoam
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double houseSurfaceArea = double.Parse(Console.ReadLine());
            int windowsCount = int.Parse(Console.ReadLine());
            double styrofoamInAPacket = double.Parse(Console.ReadLine());
            double styrofoamPrice = double.Parse(Console.ReadLine());

            double windowsSurfaceArea = 2.4 * windowsCount;
            double surfaceArea = (houseSurfaceArea - windowsSurfaceArea) + ((houseSurfaceArea - windowsSurfaceArea) * 0.1);

            double packetsNeeded = Math.Ceiling(surfaceArea / styrofoamInAPacket);
            double cost = packetsNeeded * styrofoamPrice;

            if (cost <= budget)
            {
                Console.WriteLine("Spent: {0:F2}", cost);
                Console.WriteLine("Left: {0:F2}", budget - cost);
            }
            else
            {
                Console.WriteLine("Need more: {0:F2}", Math.Abs(budget - cost));
            }
        }
    }
}
