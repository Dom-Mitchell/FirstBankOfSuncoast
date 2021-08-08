using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

namespace FirstBankOfSuncoast
{
    class UserDatabase
    {
        private List<User> Users { get; set; } = new List<User>();

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

        // CREATE Add User
        public void AddUser(User newUser)
        {
            Users.Add(newUser);
        }

        public User FindOneUser(string nameToFind)
        {
            User foundUser = Users.FirstOrDefault(user => user.UserName.ToUpper().Contains(nameToFind.ToUpper()));

            return foundUser;
        }

        public void UserExists(string nameToFind)
        {
            var foundUserName = Users.Any(user => user.UserName.Equals(nameToFind));
            var notUserName = false;
            var noLongEnough = false;

            while (!notUserName)
            {

                if (foundUserName)
                {

                    while (!noLongEnough)
                    {
                        Console.WriteLine("User found!");
                        Console.WriteLine($"What is you pin number, {nameToFind}? ");


                        var usersPassword = Console.ReadLine();
                        if (usersPassword.Length == 4)
                        {
                            var user = Users.First(user => user.Password == Int32.Parse(usersPassword));
                            //var foundUserPassword = Users.Where(user => user.Password.Equals(usersPassword));
                            if (Int32.Parse(usersPassword) == user.Password)
                            {
                                Console.WriteLine("User pin matches!");
                                Console.WriteLine("\n\n\n\n\n\n\n\nVerifying...");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Your password is NOT correct!\nPlease try again!");
                                break;
                            }

                            //break;
                        }
                        else
                        {
                            Console.WriteLine("\nYour answer was invalid. Please try again!");
                            Console.WriteLine("Your choice must be 4 characters long");
                        }

                    }


                    break;
                    // return foundUserName.ToString();
                }
                else
                {
                    Console.WriteLine("Your username is NOT correct!\nPlease try again!");
                    // return null;
                    break;
                }
            }
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
        }

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
    }
}
