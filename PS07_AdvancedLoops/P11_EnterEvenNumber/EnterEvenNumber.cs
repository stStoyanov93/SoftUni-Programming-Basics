using System;

namespace P11_EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    number = int.Parse(Console.ReadLine());

                    if (number % 2 == 0)
                    {
                        break;
                    }

                    Console.WriteLine("The number is not even.");
                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            Console.WriteLine($"Even number entered: {number}");
        }
    }
}
