using System;

namespace P05_TrapeziodArea
{
    class TrapeziodArea
    {
        static void Main(string[] args)
        {
            double firstBase = double.Parse(Console.ReadLine());
            double secondBase = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());

            double area = (firstBase + secondBase) * hight / 2;
            Console.WriteLine(area);
        }
    }
}
