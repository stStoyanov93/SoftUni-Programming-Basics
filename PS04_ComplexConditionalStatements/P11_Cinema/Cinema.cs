using System;

namespace P11_Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine().ToLower();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            decimal currentTicketPrice = 0M;

            switch (projectionType)
            {
                case "premiere":
                    currentTicketPrice = 12M;
                    break;
                case "normal":
                    currentTicketPrice = 7.5M;
                    break;
                case "discount":
                    currentTicketPrice = 5M;
                    break;
            }

            Console.WriteLine(Math.Round(row * column * currentTicketPrice, 2) + " leva");
        }
    }
}
