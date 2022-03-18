using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your year of birth:");

            int userAge = Convert.ToInt32(Console.ReadLine());
            if (userAge > 2004)
            {
                Console.WriteLine("Too young to drive.");
            }
            else if (userAge < 2004)
            { Console.WriteLine("Drive carefully"); }
            else
            {
                Console.WriteLine("Congratulation!You may applay for your driving lisence now!");
            }

            Console.WriteLine("Have a nice day.");
        }
    }
}
