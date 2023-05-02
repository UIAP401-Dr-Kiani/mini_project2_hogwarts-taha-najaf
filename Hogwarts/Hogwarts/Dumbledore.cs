using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Hogwarts
{
    public class Dumbledore : AllowedPersons
    {
        Dormitory dormitorylist;
        public string username { get; set; }
        public string password { get; set; }
        public string ReceivedLetterOfStudent { get; set; }
        public static bool Authentication()
        {
            bool choice=false;
            Console.WriteLine("Please enter your username");
            string username=Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string password=Console.ReadLine();
            if (username == null || password==null)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter valid information");
                Console.ResetColor();
                choice = false;
            }
            else if (username != "Admin" || password != "****" )
            {
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine("Your username or password is wrong");
                Console.ResetColor();
                choice = false;
            }
            else if (username == "Admin" && password == "****")
            {
                Console.ForegroundColor=ConsoleColor.Blue;
                Console.WriteLine("Correct");
                Console.ResetColor();
                choice = true;
            }
            return choice;
            
        }
        public static void SendLetter(List<AllowedPersons> persons)
        {
            int trainHour = 8;
            int personsPerTrain = 50;

            for (int i = 0; i < persons.Count; i++)
            {
                int trainNumber = i / personsPerTrain + 1;
                trainHour += (i % personsPerTrain == 0 && i > 0) ? 1 : 0;

                AllowedPersons person = persons[i];
                if (person.Role != Role.teacher)
                {
                    string letter = $"Hello dear {person.FirstName} {person.LastName},\n" +
                                    $"Welcome to Hogwarts!\n" +
                                    $"Your train information:\n" +
                                    $"Train Number: {trainNumber}\n" +
                                    $"Train Departure Time: {trainHour}:00\n" +
                                    $"Remember, if you miss the train, you'll have to wait an hour for the next one.";

                    person.ReceivedLetter = letter;
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Letters sent to the students.");
            Console.ResetColor();
        }
        public static void Gardening (Plant plant)
        {
            plant.NumberOfPlants += 20;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Plants gardened in the jungle.");
            Console.ResetColor();
        }
    }
}
