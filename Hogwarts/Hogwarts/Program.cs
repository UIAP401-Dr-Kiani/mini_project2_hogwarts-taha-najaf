using System;
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
            List <AllowedPersons> ListOfAllowedPersons = new List <AllowedPersons> ();
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

                    ListOfAllowedPersons.Add(allowedPersons);
                }
                file.Close();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("                             -----*****Welcome to the Hogwarts Management System****----     ");
            Console.ResetColor();
            while (true)
            {
                int Entrychoice = Menu.EnteryMenu();
                if (Entrychoice == 4)
                    break;
                if (Entrychoice == 1)//Dumbledore menu
                {
                    Dumbledore dumbledore = new Dumbledore();
                    List<AllowedPersons> allowedPersons = new List<AllowedPersons>();
                    Plant plant = new Plant();
                    bool AuthenticationResult = Dumbledore.Authentication();
                    if (AuthenticationResult==true)
                    {
                        int DumbledoreChoice = Menu.DumbledoreMenu();
                        if (DumbledoreChoice == 3)//exit
                            continue;
                        else if (DumbledoreChoice == 1)

                            Dumbledore.SendLetter(allowedPersons);
                        else if (DumbledoreChoice == 2)
                            Dumbledore.Gardening(plant);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (Entrychoice==2)//teacher 
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Please enter your username");
                    string username = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Please enter your Lastname");
                    string password = Console.ReadLine();
                    Console.ResetColor();
                    bool found = false;
                    foreach (var person in ListOfAllowedPersons)
                    {
                        if (person.Role==Role.teacher && person.Username == username &&person.Password==password)
                        {
                            found = true;
                            int TeacherChoice=Menu.TeacherMenu();
                            if (TeacherChoice == 1)//define lesson
                            {
                                Lessons Newlesson = new Lessons();
                                Newlesson.DefineLesson(person.FirstName,person.LastName);
                            }
                            else if (TeacherChoice == 2)//define homework
                            {
                                Lessons.DefineHomework();
                            }
                            else if (TeacherChoice == 3)//set score
                            {

                            }
                            else if (TeacherChoice == 4)//confirm grade
                            {

                            }
                            else if (TeacherChoice == 5)//exit
                                continue;
                                

                            
                        }

                    }
                    if (found==false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong username or Lastname");
                        Console.ResetColor();
                        continue;
                    }
                }
                
                else if (Entrychoice == 3)//student 
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Please enter your username");
                    string username=Console.ReadLine();
                    Console.ForegroundColor= ConsoleColor.DarkGray;
                    Console.WriteLine("Please enter your password");
                    string password = Console.ReadLine();
                    Console.ResetColor();
                    bool found=false;
                    foreach (var person in ListOfAllowedPersons)
                    {
                        if (person.Role==Role.student && person.Username==username&&person.Password==password)
                        {
                            found= true;
                            int studentChoice=Menu.StudentMenu();
                            if (studentChoice == 1)//send letter to dumbledore 
                            {
                                Student.SendLetterToDumbledore(Firstname: person.FirstName, Lastname: person.LastName);
                            }
                            else if (studentChoice == 2)//take data
                            {
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine($"Your informations are:\n" +
                                    $"Name:{person.FirstName + person.LastName}\n" +
                                    $"Pet :{person.Pet}\n" +
                                    $"Role: {person.Role}\n" +
                                    $"Letters:  {person.ReceivedLetter}");
                                Console.ResetColor();
                            }
                            else if (studentChoice == 3)//choose unit
                            {
                                Student.SelectLesson();
                            }
                            else if (studentChoice == 4)//upload homework
                            {

                            }
                            else if (studentChoice == 5)//exit
                                continue;
                        }
                    }
                    if (!found)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong username or Lastname");
                        Console.ResetColor();
                        continue;
                    }
                }
            }
            Console.WriteLine("Thanks for using our system.");
            Console.ReadKey();
        }
    }
}
