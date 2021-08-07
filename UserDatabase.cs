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

        public void UserNameExists(string nameToFind)
        {
            var notUserName = false;
            while (!notUserName)
            {
                var foundUserName = Users.FirstOrDefault(user => user.UserName.Contains(nameToFind));

                if (foundUserName.ToString() == nameToFind)
                {
                    break;

                }
                else
                {
                    Console.WriteLine("Your username is NOT correct!\nPlease try again!");
                }
            }

            //var userExists = Users.Contains(Users.UserName(nameToFind));
        }
    }
}
