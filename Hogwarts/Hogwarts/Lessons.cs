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
        public  void DefineLesson(string name, string time, int capacity, int currentTerm)
        {
            Name = name;
            Time = time;
            Capacity = capacity;
            CurrentTerm = currentTerm;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The lesson: {name}\n" +
                $" with time:{time}\n" +
                $"capacity: {capacity}\n" +
                $"in term {currentTerm} defined");
            Console.ResetColor();
        }
    }
}
