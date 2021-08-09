using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using Pastel;

namespace FirstBankOfSuncoast
{
    class UserDatabase
    {
        private List<User> Users { get; set; } = new List<User>();
        public User SingularUser = new User();
        public bool UserMatches = false;

        private string FileName = "Users.csv";

        public void LoadUsers()
        {
            if (File.Exists(FileName))
            {
                var fileReader = new StreamReader(FileName);

                var csvReader = new CsvReader(fileReader, CultureInfo.InvariantCulture);

                // Replace our BLANK list of employees with the ones that are in the CSV file
                Users = csvReader.GetRecords<User>().ToList();

                fileReader.Close();
            }
        }

        public void SaveUsers()
        {
            var fileWriter = new StreamWriter(FileName);

            var csvWriter = new CsvWriter(fileWriter, CultureInfo.InvariantCulture);

            csvWriter.WriteRecords(Users);

            fileWriter.Close();
        }

        public void CreateUser()
        {
            var correctUserNameLength = false;
            var correctPinLength = false;

            var newUserName = "";
            var newPin = 0;

            while (!correctUserNameLength)
            {
                Console.WriteLine("\nWhat do you want to be your username? (8 Characters max) ");
                newUserName = Console.ReadLine();

                if (newUserName.Length <= 8)
                {
                    if (Users.Any(user => user.UserName == newUserName))
                    {
                        Console.WriteLine("That username is taken. Please Try again!");
                        Console.WriteLine("Your choice must be a maximum of 8 characters long");
                        continue;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("\nYour answer was invalid. Please try again!");
                    Console.WriteLine("Your choice must be a maximum of 8 characters long");
                }
            }

            while (!correctPinLength)
            {
                Console.WriteLine("What do you want your pin to be? (4 numbers, ####) ");
                newPin = Int32.Parse(Console.ReadLine());

                if (newPin.ToString().Length == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nYour answer was invalid. Please try again!");
                    Console.WriteLine("Your choice must be 4 numbers long");
                }
            }

            SingularUser.UserName = newUserName;
            SingularUser.Password = newPin;

            Users.Add(SingularUser);
            SaveUsers();

        }

        public void ExistingUser()
        {
            var correctUserNameLength = false;
            var correctPinLength = false;

            var existingUserName = "";

            while (!correctUserNameLength)
            {
                Console.WriteLine("\nPlease enter your username (8 Characters max) ");
                existingUserName = Console.ReadLine();

                if (existingUserName.Length <= 8)
                {
                    if (Users.Any(user => user.UserName == existingUserName))
                    {
                        Console.Write($"{"User found!".Pastel(Color.LimeGreen)}\n");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect username. Please try again!");
                        Console.WriteLine("Your choice must be a maximum of 8 characters long");
                    }

                }
                else
                {
                    Console.WriteLine("Your answer was invalid. Please try again!");
                    Console.WriteLine("Your choice must be a maximum of 8 characters long");
                }


            }

            while (!correctPinLength)
            {
                Console.WriteLine("\nPlease enter your pin number (4 numbers, ####) ");
                var existingPassword = "";

                StringBuilder sb = new StringBuilder();
                while (true)
                {
                    var keyPressed = Console.ReadKey(true);

                    if (keyPressed.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    if (keyPressed.Key == ConsoleKey.Backspace)
                    {
                        if (sb.Length > 0)
                        {
                            Console.Write("\b \b");
                            sb.Length--;
                        }
                        continue;
                    }

                    Console.Write("*");
                    sb.Append(keyPressed.KeyChar);


                }
                existingPassword += sb.ToString();
                // Console.WriteLine($"\n{existingPassword}");

                if (existingPassword.Length == 4)
                {
                    SingularUser = Users.First(user => user.UserName == existingUserName);
                    if (SingularUser.Password.ToString() == existingPassword)
                    {
                        Console.WriteLine($"\n{"Password correct!".Pastel(Color.LimeGreen)}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Please try again!");
                        Console.WriteLine("Your choice must be 4 numbers long");
                    }
                }
                else
                {
                    Console.WriteLine("\nYour answer was invalid. Please try again!");
                    Console.WriteLine("Your choice must be 4 numbers long");
                }

            }

            UserMatches = true;
        }

    }
}



//     if (foundUserName)
//     {

//         while (!noLongEnough)
//         {
//             Console.WriteLine("User found!");
//             Console.WriteLine($"What is you pin number, {nameToFind}? ");


//             var usersPassword = Console.ReadLine();
//             if (usersPassword.Length == 4)
//             {
//                 var user = Users.First(user => user.Password == Int32.Parse(usersPassword));
//                 //var foundUserPassword = Users.Where(user => user.Password.Equals(usersPassword));
//                 if (Int32.Parse(usersPassword) == user.Password)
//                 {
//                     Console.WriteLine("User pin matches!");
//                     Console.WriteLine("Verifying...\n\n\n\n\n\n");
//                     break;
//                 }
//                 else
//                 {
//                     Console.WriteLine("Your password is NOT correct!\nPlease try again!");
//                     break;
//                 }

//                 //break;
//             }
//             else
//             {
//                 Console.WriteLine("\nYour answer was invalid. Please try again!");
//                 Console.WriteLine("Your choice must be 4 characters long");
//             }

//         }


//         break;
//         // return foundUserName.ToString();
//     }
//     else
//     {
//         Console.WriteLine("Your username is NOT correct!\nPlease try again!");
//         // return null;
//         break;
//     }
// }
//var foundUserPassword = Users.Any(user => user.Password.Equals(passwordToFind) == user.Password.Equals(nameToFind));

// while (!notUserPassword)
// {



//     if (foundUserName)
//     {
//         Console.WriteLine("Password found!");
//         notUserPassword = true;
//         // break;
//     }
//     else
//     {
//         Console.WriteLine("Your password is NOT correct!\nPlease try again!");
//         notUserPassword = false;
//         // break;
//     }
// }

// return null;

//var userExists = Users.Contains(Users.UserName(nameToFind));
// }

// public void UserPassWordExists(int passwordToFind)
// {
//     var notUserPassword = false;
//     // while (!notUserPassword)
//     // {

//     //     var foundUserName = Users.Any(user => user.Password.Equals(passwordToFind));

//     //     if (foundUserName)
//     //     {
//     //         Console.WriteLine("Password found!");
//     //         break;
//     //     }
//     //     else
//     //     {
//     //         Console.WriteLine("Your password is NOT correct!\nPlease try again!");
//     //         break;
//     //     }
//     // }

//     //var userExists = Users.Contains(Users.UserName(nameToFind));
// }
