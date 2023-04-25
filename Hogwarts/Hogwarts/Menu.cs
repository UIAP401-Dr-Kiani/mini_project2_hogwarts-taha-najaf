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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("     -----*****Welcome to the Hogwarts Management System****----     ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter your role by number:\n 1=>Dumbledore\t2=>Teachers\t3=>Student\t4=>Exit");
            int choice = int.Parse(Console.ReadLine());
            Console.ResetColor();
            return choice;
        }
        public static int DumbledoreMenu()
        {
            Console.ForegroundColor= ConsoleColor.Yellow;
            Console.WriteLine("     ----****Welcome to the Dumbledore(Admin) menu****----       ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Please enter your choice by numbers:     ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1=>Sending letters to students\t2=>Exit");
            int choice=int.Parse(Console.ReadLine());
            Console.ResetColor();
            return choice;
        }
        
    }
}
