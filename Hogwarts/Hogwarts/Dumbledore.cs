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
        
        public static int Authentication()
        {
            int choice=0;
            Console.WriteLine("Please enter your username");
            string username=Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string password=Console.ReadLine();
            if (username == null || password==null)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Please enter valid information");
                choice = 0;
            }
            else if (username != "Admin" && password != "****" )
            {
                Console.ForegroundColor= ConsoleColor.DarkRed;
                Console.WriteLine("Your username or password is wrong");
                choice = 0;
            }
            else if (username == "Admin" && password == "****")
            {
                Console.ForegroundColor=ConsoleColor.Blue;
                Console.WriteLine("Correct");
                choice = 1;
            }
            return choice;
            
        }
    }
}
