using System;

namespace P05_InvalidNumber
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isInRange = (number >= 100 && number <= 200 || number == 0);

            if (!isInRange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
