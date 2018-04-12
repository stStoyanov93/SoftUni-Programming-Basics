using System;

namespace P12_Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine().ToLower();
            int holidaysCount = int.Parse(Console.ReadLine());
            int weekendsAtHome = int.Parse(Console.ReadLine());

            int remainingWeekends = 48 - weekendsAtHome;
            double playdays = (remainingWeekends * 3.0 / 4) + (holidaysCount * 2.0 / 3) + weekendsAtHome;

            if (typeOfYear == "normal")
            {
                Console.WriteLine("{0}", (int)playdays);
            }
            else
            {
                Console.WriteLine("{0}", (int)(playdays * 0.15 + playdays));
            }
        }
    }
}
