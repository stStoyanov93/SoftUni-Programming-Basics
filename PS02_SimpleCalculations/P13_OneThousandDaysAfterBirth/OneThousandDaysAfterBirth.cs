using System;
using System.Globalization;

namespace P13_OneThousandDaysAfterBirth
{
    class OneThousandDaysAfterBirth
    {
        static void Main(string[] args)
        {
            var date = Console.ReadLine();
            string format = "dd-MM-yyyy";

            DateTime oneThousandDaysLater = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
            oneThousandDaysLater = oneThousandDaysLater.AddDays(999);

            Console.WriteLine(oneThousandDaysLater.ToString(format));
            Console.ReadLine();
        }
    }
}
