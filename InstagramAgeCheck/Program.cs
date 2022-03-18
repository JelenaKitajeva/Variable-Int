using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");

            int userAge = Convert.ToInt32(Console.ReadLine());
            if (userAge < 13)
            {
                Console.WriteLine("You are soo young for Instagram.");
            }
            else if(userAge > 13)
                { Console.WriteLine("Welcome to Instagram!"); }
            else
            { Console.WriteLine("Congratulation!You may use Instagram now!"); 
            }

            Console.WriteLine("Have a nice day.");
        }
    }
}
