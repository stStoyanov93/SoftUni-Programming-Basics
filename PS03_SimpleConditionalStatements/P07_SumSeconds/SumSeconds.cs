using System;

namespace P07_SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int sum = a + b + c;

            int minutes = sum / 60;
            int seconds = sum % 60;

            Console.WriteLine($"{minutes}:{seconds.ToString().PadLeft(2, '0')}");
        }
    }
}
