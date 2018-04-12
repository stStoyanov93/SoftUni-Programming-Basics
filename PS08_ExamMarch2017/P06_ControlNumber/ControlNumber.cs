using System;

namespace P06_ControlNumber
{
    class ControlNumber
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int controlNumber = int.Parse(Console.ReadLine());

            int moves = 0;
            int sum = 0;

            for (int i = 1; i <= firstNumber; i++)
            {
                if (sum >= controlNumber)
                {
                    break;
                }
                for (int j = secondNumber; j >= 1; j--)
                {
                    if (sum >= controlNumber)
                    {
                        break;
                    }
                    sum += (i * 2) + (j * 3);
                    moves++;
                }
            }

            if (sum >= controlNumber)
            {
                Console.WriteLine(moves + " moves");
                Console.WriteLine("Score: " + sum + " >= " + controlNumber);
            }
            else
            {
                Console.WriteLine(moves + " moves");
            }
        }
    }
}
