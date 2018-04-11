using System;


namespace P02_InchesToCentimeters
{
    class InchesToCentimeters
    {
        static void Main(string[] args)
        {
            double intches = double.Parse(Console.ReadLine());
            double centimeters = intches * 2.54;

            Console.WriteLine($"Centemeters = {centimeters}");
        }
    }
}
