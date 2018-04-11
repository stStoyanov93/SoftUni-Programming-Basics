using System;

namespace P04_TriangleOf55Stars
{
    class TriangleOf55Stars
    {
        static void Main(string[] args)
        {
            int startNumber = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('*', startNumber));
                startNumber++;
            }
        }
    }
}
