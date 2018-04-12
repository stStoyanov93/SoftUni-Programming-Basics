using System;

namespace P09_DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string[] dayOfTheWeek = new string[8]
            { "Not a day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int userNumberInput = int.Parse(Console.ReadLine());

            switch (userNumberInput)
            {
                case 0:
                    Console.WriteLine(dayOfTheWeek[userNumberInput]);
                    break;
                case 1:
                    Console.WriteLine(dayOfTheWeek[userNumberInput]);
                    break;
                case 2:
                    Console.WriteLine(dayOfTheWeek[userNumberInput]);
                    break;
                case 3:
                    Console.WriteLine(dayOfTheWeek[userNumberInput]);
                    break;
                case 4:
                    Console.WriteLine(dayOfTheWeek[userNumberInput]);
                    break;
                case 5:
                    Console.WriteLine(dayOfTheWeek[userNumberInput]);
                    break;
                case 6:
                    Console.WriteLine(dayOfTheWeek[userNumberInput]);
                    break;
                case 7:
                    Console.WriteLine(dayOfTheWeek[userNumberInput]);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
