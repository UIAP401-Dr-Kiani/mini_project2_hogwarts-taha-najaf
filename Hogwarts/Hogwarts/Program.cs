﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <AllowedPersons> persons = new List <AllowedPersons> ();
            using (StreamReader file = new StreamReader("TXT_DATA.tsv"))
            {
                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    AllowedPersons allowedPersons = new AllowedPersons();
                    string[] human = ln.Split('\t').ToArray<string>();

                    allowedPersons.FirstName = human[0];
                    allowedPersons.LastName = human[1];
                    allowedPersons.Birthday = human[2];
                    allowedPersons.Gender = human[3];
                    allowedPersons.FatherName = human[4];
                    allowedPersons.Username = human[5];
                    allowedPersons.Password = human[6];
                    if (human[7] == "HalfBlood")//--- for breed or race type
                        allowedPersons.breedType = BreedType.HalfBlood;
                    else if (human[7] == "PureBlood")
                        allowedPersons.breedType = BreedType.PureBlood;
                    else if (human[7] == "MuggleBlood")
                        allowedPersons.breedType = BreedType.MuggleBlood;
                    if (human[8] == "teacher")//---for role
                        allowedPersons.Role = Role.teacher;
                    else if (human[8] == "student")
                        allowedPersons.Role = Role.student;

                    persons.Add(allowedPersons);
                }
                file.Close();
            }
            int Entrychoice=Menu.EnteryMenu();
            while(Entrychoice!=4)
            {
                if (Entrychoice==1)
                {
                    List<AllowedPersons> allowedPersons = new List<AllowedPersons>();
                    Plant plant = new Plant();
                    int AuthenticationResult = Dumbledore.Authentication();
                    if (AuthenticationResult == 0)
                        continue;
                    else
                    {
                        int DumbledoreChoice=Menu.DumbledoreMenu();
                        if (DumbledoreChoice == 3)
                            continue;
                        else if (DumbledoreChoice == 1)
                            Dumbledore.SendLetter(allowedPersons);
                        else if (DumbledoreChoice == 2)
                            Dumbledore.Gardening(plant);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
