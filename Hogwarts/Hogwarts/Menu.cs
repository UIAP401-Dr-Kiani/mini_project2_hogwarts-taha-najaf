using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    public class Menu
    {
        public static int EnteryMenu()
        {
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    //Console.BackgroundColor = ConsoleColor.White;
        //    Console.WriteLine("                             -----*****Welcome to the Hogwarts Management System****----     ");
            //Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter your role by number:\n" +
                "1=>Dumbledore      2=>Teachers     3=>Student      4=>Exit");
            int choice = int.Parse(Console.ReadLine());
            Console.ResetColor();
            return choice;
        }
        public static int DumbledoreMenu()
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("     ----****Welcome to the Dumbledore(Admin) menu****----       ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter your choice by number:     ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1=>Sending letters to students\t2=>Gardening\t3=>Exit");
            int choice=int.Parse(Console.ReadLine());
            Console.ResetColor();
            return choice;
        }
        public static int TeacherMenu()
        {
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("     ----****Welcome to the Teachers menu****----       ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter your choice by numbers:     ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1=>Define lessons\t2=>Define homework\t3=>Set score for students\t4=>Confirm students grades\t5=>Exit  ");
            int choice = int.Parse(Console.ReadLine());
            Console.ResetColor();
            return choice;
        }
        public static int StudentMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("     ----****Welcome to the Students menu****----       ");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter your choice by numbers:     ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1=>Send request to Dumbledore for going back to the city\t2=>Take your data\t3=>Choosing unit\t" +
                "4=>Upload homework\t5=>Exit");
            Console.ResetColor();
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
