using System;

namespace DayMakerMachine
{
    // Creation of the word banks to be pulled for the compliment
    public class Adjectives
    {

        public static string[] Words = { "Beautiful", "Brilliant", "Charming", "Delightful", "Elegant", "Fantastic", "Graceful", "Handsome", "Inspiring", "Joyful", "Kindhearted", "Lovely", "Magnificent", "Noble", "Outstanding", "Passionate", "Radiant", "Stunning", "Talented", "Vibrant" };
    }


    public class AdjectivesVerbs
    {

        public static string[] Words = { "Courageous", "Enchanting", "Fascinating", "Generous", "Harmonious", "Inspiring", "Majestic", "Noble", "Resilient", "Serene", "Achieving", "Creating", "Delighting", "Enriching", "Excelling", "Inspiring", "Mesmerizing", "Radiating", "Uplifting", "Empowering" };
    }


    public class Nouns
    {

        public static string[] Words = { "Fella", "Person", "Leader", "Friend", "Companion", "Partner", "Individual", "Soul", "Gem", "Treasure", "Star", "Champion", "Hero", "Darling", "Beauty", "Spirit", "Wonder", "Jewel", "Gemstone", "Sweetheart" };
    }

    class Program
    {// this is the display to the user creating the prompt to kick off the "slots"
     // The class: Program is open for extension but closed for modification
     // if you want to add new features you can certainly do so like extending the words of the compliment beyond 3
     // but you don't need to modify the existing code, thus employing the Open/Closed Principle
        static void Main(string[] args)
        {
            LogEvent("Application started");

            Console.WriteLine("Hello! Welcome to the Day Maker Machine! A.K.A Compliment Slots!");
            Console.WriteLine("Please type SPIN and hit enter to get a boost of self-confidence!");

            string userInput = Console.ReadLine();

            if (userInput.ToUpper() == "SPIN")
            {

                GenerateAndDisplayCompliment();
            }   // Generate and display the compliment
            else
            {
                Console.WriteLine("Invalid input. Please type SPIN and hit enter.");
            }   // or display essentially an error message if any unrecognized command is used and log it
            LogEvent("Invalid input received: " + userInput);
        }

        static void GenerateAndDisplayCompliment()
        {

            string adjective = Adjectives.Words[new Random().Next(Adjectives.Words.Length)];
            string adjectiveVerb = AdjectivesVerbs.Words[new Random().Next(AdjectivesVerbs.Words.Length)];
            string noun = Nouns.Words[new Random().Next(Nouns.Words.Length)];
            // Select one word to be randomly pulled from each class

            string compliment = $"{adjective} {adjectiveVerb} {noun}";
            // Construct the compliment

            Console.WriteLine("Your compliment for today is: " + compliment);
            LogEvent("Compliment generated: " + compliment);
        }   // Display the compliment/Final Product of the Day Maker Machine and log the success
        static void LogEvent(string message)
        {// this is the creation of our "LogEvent" method that will keep track of events in a txt file
         // also the LogEvent method has a single "responsibility" of logging messages to a text file
         // thus employing the Single Responsibility Principle
            string logFilePath = "log.txt";
            try
            {
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine($"{DateTime.Now}: {message}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while logging: {ex.Message}");
            }
        }
    }
}
