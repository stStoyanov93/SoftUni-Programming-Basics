using System;

namespace P01_GrapeAndRakia
{
    class GrapeAndRakia
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            double kgPerSqureMeter = double.Parse(Console.ReadLine());
            double losses = double.Parse(Console.ReadLine());

            double remGrapes = (size * kgPerSqureMeter) - losses;

            double rakia = (remGrapes * 0.45) / 7.5;
            double rakiaIncome = rakia * 9.8;

            double grapesIncome = (remGrapes * 0.55) * 1.5;

            Console.WriteLine("{0:F2}", rakiaIncome);
            Console.WriteLine("{0:F2}", grapesIncome);
        }
    }
}
