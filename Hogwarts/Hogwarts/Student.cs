using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Student : AllowedPersons
    {
        public int PassedUnits { get; set; }
        public int Term { get; set; }
        public int DormitoryNumber { get; set; }
        public static void SendLetterToDumbledore(string Firstname,string Lastname)
        {
            string request = $"You have new message from student with this firstname {Firstname} and lastname {Lastname}\n" +
                "Dear Dumbledore\n" +
                "I am writing to request permission to return to the city. ";
            Dumbledore.ReceivedLetterOfStudent = request;
            Console.WriteLine("Request sent to the Dumbledore");
        }
        public static void SelectLesson()
        {
           // Lessons lessons=new Lessons();
            Console.WriteLine("Please enter the time:   ");
            string time=Console.ReadLine();
            // Display the available ListOfLessons for the given time
            Console.WriteLine($"Available ListOfLessons at {time}:");
            foreach (var lesson in Lessons.ListOfLessons)
            {
                //if (lesson.Time == time)
                //{
                    Console.WriteLine($" {lesson.Name}");
                //}
            }

            // Prompt the student to select a lesson
            Console.Write("Select a lesson: ");
            string selectedLesson = Console.ReadLine();

            // Check if the selected lesson conflicts with any other selected ListOfLessons
            foreach (var lesson in Lessons.ListOfLessons)
            {
                if (lesson.Name == selectedLesson && lesson.Time == time)
                {
                    Console.WriteLine($"You have successfully selected {selectedLesson} at {time}.");
                    return;
                }
                else if (lesson.Name == selectedLesson && lesson.Time == time)
                {
                    Console.WriteLine($"Sorry, {selectedLesson} at {time} is already taken.");
                    return;
                }
            }

            Console.WriteLine("Invalid lesson selection.");
        }

    }


}
