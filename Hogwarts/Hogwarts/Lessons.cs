using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public static List<Lessons> ListOfLessons =new List<Lessons>();
        
        public void DefineLesson(string firstname,string lastname)
        {
         
            Console.WriteLine("Please enter the number of the lesson: \n" +
                "1=>Chemistry      2=>Botanical     3=>Sport      4=>Occultism       5=>Exit");
            int choice=int.Parse(Console.ReadLine());
            string name="";
            switch (choice)
            {
                case 1:
                    name = "Chemistry";
                    break;
                case 2:
                    name = "Botanical";
                    break;
                case 3:
                    name = "Sport";
                    break;
                case 4:
                    name = "Occultism";
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
            Console.WriteLine("Please enter it's time with this format start:finish(for example 8:10 which means start at 8 and finished at 10): ");
            string time=Console.ReadLine();
            Console.WriteLine("Please enter it's capacity:  ");
            int capacity=int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the term: ");
            int currentTerm=int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The lesson:{name}\n" +
                $"with time:{time} \n" +
                $"capacity: {capacity}\n" +
                $"in term: {currentTerm} \n" +
                $"was defined by {firstname} {lastname}");
            Lessons Newlessons = new Lessons();
            Newlessons.Name = name;
            Newlessons.Time = time;
            Newlessons.Capacity= capacity;
            Newlessons.CurrentTerm= currentTerm;
            ListOfLessons.Add( Newlessons );
            Console.ResetColor();
        }
        public static void DefineHomework()
        {
            Console.WriteLine($"Please enter the lesson you want to set homework by number:\n" +
                
                $"1=>Chemistry      2=>Botanical      3=>Sport      4=>Occultism     5=>Exit");
            int choice=int.Parse(Console.ReadLine());
            //------------------------------------ instance 
            Chemistry chemistry = new Chemistry();
            Botanical botanical = new Botanical();
            Occultism occultism = new Occultism();
            Sport sport = new Sport();
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
                case 3:
                    Console.WriteLine("Enter the homework for Sport:");
                    sport.Homework= Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Homework for Sport set.");
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
