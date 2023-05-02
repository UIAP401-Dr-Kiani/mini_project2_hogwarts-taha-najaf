﻿using System;
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
        public static void SendLetterToDumbledore(string Username,string password)
        {
            string request = $"You have new message from student with this username{Username} and password {password}\n" +
                "Dear Dumbledore\n" +
                "I am writing to request permission to return to the city. ";
            Dumbledore.ReceivedLetterOfStudent = request;
            Console.WriteLine("Request sent to the Dumbledore");
        }
    }

     
}
