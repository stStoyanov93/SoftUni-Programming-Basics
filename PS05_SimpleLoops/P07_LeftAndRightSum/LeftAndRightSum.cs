﻿using System;

namespace P07_LeftAndRightSum
{
    class LeftAndRightSum
    {
        static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < controlNumber; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum += num;
            }

            for (int i = 0; i < controlNumber; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightSum += num;
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
            }
        }
    }
}
