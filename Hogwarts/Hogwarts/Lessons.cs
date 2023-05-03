using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Lessons
    {
        public string Time { get; set; }
        public int Number_of_students { get; set; }
        public int Capacity { get; set; }
        public int CurrentTerm { get; set; }
        public string Name { get; set; }
        public string Homework { get; set; }
        public void DefineLesson(string firstname,string lastname)
        {
            Console.WriteLine("Please enter the name of the lesson: ");
            Name=Console.ReadLine();
            Console.WriteLine("Please enter it's time: ");
            Time=Console.ReadLine();
            Console.WriteLine("Please enter it's capacity:  ");
            Capacity=int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the term: ");
            CurrentTerm=int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The lesson: {Name}\n" +
                $" with time:{Time}\n" +
                $"capacity: {Capacity}\n" +
                $"in term {CurrentTerm} \n" +
                $"was defined by {firstname} {lastname}");
            Console.ResetColor();
        }
        public static void DefineHomework()
        {
            Console.WriteLine($"Please enter the lesson you want to set homework by number:\n" +
                
                $"1=>Chemistry      2=>Botanical      3=>Botanicl      4=>Occultism     5=>Exit");
            int choice=int.Parse(Console.ReadLine());
            //------------------------------------ instance 
            Chemistry chemistry = new Chemistry();
            Botanical botanical = new Botanical();
            Occultism occultism = new Occultism();
            //-----------------------------------
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the homework for Chemistry:");
                    chemistry.Homework = Console.ReadLine();
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine("Homework for Chemistry set.");
                    Console.ResetColor();
                    break;
                case 2:
                    Console.WriteLine("Enter the homework for Botanical:");
                    botanical.Homework = Console.ReadLine();
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine("Homework for Botanical set.");
                    Console.ResetColor();
                    break;
                case 4:
                    Console.WriteLine("Enter the homework for Occultism:");
                    occultism.Homework = Console.ReadLine();
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    Console.WriteLine("Homework for Occultism set.");
                    Console.ResetColor();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid choice. Please try again.");
                    Console.ResetColor();
                    break;
            }
        }
    }
}
