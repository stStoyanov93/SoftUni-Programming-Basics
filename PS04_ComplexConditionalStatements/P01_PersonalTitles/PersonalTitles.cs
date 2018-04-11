using System;

namespace P01_PersonalTitles
{
    class PersonalTitles
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender == "m" && age < 16)
            {
                Console.WriteLine("Master");              
            }
            else if(gender == "m")
            {
                Console.WriteLine("Mr.");
            }

            if (gender == "f" && age < 16)
            {
                Console.WriteLine("Miss");              
            }
            else if (gender == "f")
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}
