using System;

namespace P10_CheckPrime
{
    class CheckPrime
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine("Not prime");
                return;
            }

            bool prime = true;           
            double rootOfN = Math.Sqrt(n);

            for (int i = 2; i <= rootOfN; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}
