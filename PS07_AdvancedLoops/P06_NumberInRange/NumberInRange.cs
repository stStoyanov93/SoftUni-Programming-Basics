using System;

namespace P06_NumberInRange
{
    class NumberInRange
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            while (1 > number || number > 100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Еnter a number in the range [1...100]:");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The number is: " + number);
        }
    }
}
