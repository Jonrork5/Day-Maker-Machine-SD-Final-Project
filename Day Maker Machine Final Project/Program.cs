using System;

namespace DayMakerMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the Day Maker Machine! A.K.A Compliment Slots!");
            Console.WriteLine("Please type SPIN and hit enter to get a boost of self-confidence!");

            string userInput = Console.ReadLine();

            if (userInput.ToUpper() == "SPIN")
            {
                // Call a method to generate and display the compliment

            }
            else
            {
                Console.WriteLine("Invalid input. Please type SPIN and hit enter.");
            }
        }
    }
}