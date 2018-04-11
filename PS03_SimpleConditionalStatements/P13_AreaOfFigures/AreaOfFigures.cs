using System;

namespace P13_AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double area = 0.0;

            if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (figureType == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }
            else if (figureType == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = (side * h) / 2;             
            }

            Console.WriteLine(area);
        }
    }
}
