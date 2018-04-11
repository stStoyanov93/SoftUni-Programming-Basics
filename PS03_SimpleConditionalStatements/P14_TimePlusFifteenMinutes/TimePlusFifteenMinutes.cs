using System;

namespace P14_TimePlusFifteenMinutes
{
    class TimePlusFifteenMinutes
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes > 59)
            {
                hour += 1;
                minutes -= 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }
            Console.WriteLine("{0}:{1:00}", hour, minutes);
        }
    }
}
