using System;

namespace UserPin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Pincode");
            string userName = Console.ReadLine();
            if (userName == "1234")
            {
                Console.WriteLine("Welcome!");
                Console.WriteLine("What is your name?");
                string Username = Console.ReadLine();
                Console.WriteLine("Hello " + Username + "!");
                Console.WriteLine("Have a nice day.");
            }
            else { Console.WriteLine("Oops!Invalid PIN!"); }
            
        }
    }
}
