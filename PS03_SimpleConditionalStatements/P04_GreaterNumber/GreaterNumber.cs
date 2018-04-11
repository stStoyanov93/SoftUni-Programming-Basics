using System;

namespace P04_GreaterNumber
{
    class GreaterNumber
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(num1, num2));
        }
    }
}
