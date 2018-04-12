using System;

namespace P04_Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            int mountsCount = int.Parse(Console.ReadLine());
            double electricityBill = 0.0;

            for (int i = 0; i < mountsCount; i++)
            {
                electricityBill += double.Parse(Console.ReadLine());
            }

            double waterBill = mountsCount * 20.0;
            double internetBill = mountsCount * 15.0;

            double fisrtThreeBillsSum = electricityBill + waterBill + internetBill;
            double othersBill = fisrtThreeBillsSum * 0.2 + fisrtThreeBillsSum;
            double average = (fisrtThreeBillsSum + othersBill) / mountsCount;

            Console.WriteLine("Electricity: {0:F2} lv", electricityBill);
            Console.WriteLine("Water: {0:F2} lv", waterBill);
            Console.WriteLine("Internet: {0:F2} lv", internetBill);
            Console.WriteLine("Other: {0:F2} lv", othersBill);
            Console.WriteLine("Average: {0:F2} lv", average);
        }
    }
}
