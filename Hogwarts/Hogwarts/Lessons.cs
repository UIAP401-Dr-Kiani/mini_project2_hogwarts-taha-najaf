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
        public void DefineLesson()
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
                $"in term {CurrentTerm} defined");
            Console.ResetColor();
        }
    }
}
