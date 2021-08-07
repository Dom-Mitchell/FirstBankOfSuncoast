using System;
using System.Drawing;
using Pastel;

namespace FirstBankOfSuncoast
{
    class Program
    {
        static void DisplayGreeting()
        {
            // Sun from https://textart.io/art/tag/sun/1 & Ascii text from https://www.ascii-art-generator.org/
            // Console.WriteLine($@"  #####   #####     ######                                       {@"            \       |         /         ".Pastel(Color.DarkOrange)}");
            // Console.WriteLine($@" #     # #     #    #     #   ##   #    # #    # # #    #  ####  {@"  .          .      |        .        . ".Pastel(Color.DarkOrange)}");
            // Console.WriteLine($@" #       #          #     #  #  #  ##   # #   #  # ##   # #    # {@"    .         \             /       .   ".Pastel(Color.DarkOrange)}");
            // Console.WriteLine($@"  #####  #          ######  #    # # #  # ####   # # #  # #      {@"      '  .     \    |      /      .     ".Pastel(Color.DarkOrange)}");
            // Console.WriteLine($@"       # #          #     # ###### #  # # #  #   # #  # # #  ### {@"            .  ,+~'`^`'~+,/   , '       ".Pastel(Color.DarkOrange)}");
            // Console.WriteLine($@" #     # #     #    #     # #    # #   ## #   #  # #   ## #    # {@"             .'           '.'           ".Pastel(Color.DarkOrange)}");
            // Console.WriteLine($@"  #####   #####     ######  #    # #    # #    # # #    #  ####  {@"   --- -- - /               \ - -- ---  ".Pastel(Color.DarkOrange)}");

            Console.WriteLine($"{"  #####   #####   ".Pastel(Color.LightSkyBlue)}  {"######                                       ".Pastel(Color.SeaGreen)}{@"            \       |         /         ".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{" #     # #     #  ".Pastel(Color.LightSkyBlue)}  {"#     #   ##   #    # #    # # #    #  ####  ".Pastel(Color.SeaGreen)}{@"  .          .      |        .        . ".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{" #       #        ".Pastel(Color.LightSkyBlue)}  {"#     #  #  #  ##   # #   #  # ##   # #    # ".Pastel(Color.SeaGreen)}{@"    .         \             /       .   ".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{"  #####  #        ".Pastel(Color.LightSkyBlue)}  {"######  #    # # #  # ####   # # #  # #      ".Pastel(Color.SeaGreen)}{@"      '  .     \    |      /      .     ".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{"       # #        ".Pastel(Color.LightSkyBlue)}  {"#     # ###### #  # # #  #   # #  # # #  ### ".Pastel(Color.SeaGreen)}{@"            .".Pastel(Color.OrangeRed)} {" ,+~'`^`'~+,".Pastel(Color.DarkOrange)}{@"/   , '".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{" #     # #     #  ".Pastel(Color.LightSkyBlue)}  {"#     # #    # #   ## #   #  # #   ## #    # ".Pastel(Color.SeaGreen)}{@"             .'           '.".Pastel(Color.DarkOrange)}{"'".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{"  #####   #####   ".Pastel(Color.LightSkyBlue)}  {"######  #    # #    # #    # # #    #  ####  ".Pastel(Color.SeaGreen)}{@"   --- -- -".Pastel(Color.OrangeRed)} {@"/               \".Pastel(Color.DarkOrange)} {"- -- ---  ".Pastel(Color.OrangeRed)}\n");
            Console.WriteLine($"{"############################################################################################################".Pastel(Color.LightSlateGray)}");
            Console.WriteLine($"{"############################################################################################################".Pastel(Color.LightSlateGray)}");
        }

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();

            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry, that isn't a valid input, I'm using 0 as your answer.");
                return 0;
            }
        }

        private static void AddUser(UserDatabase database)
        {
            var user = new User();
            var correctPinLength = false;
            var correctUserNameLength = false;

            while (!correctUserNameLength)
            {
                user.UserName = PromptForString("\nWhat do you want to be your username? (8 Characters max) ");

                if (user.UserName.Length <= 8)
                {
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
                user.Password = PromptForInteger("What do you want your pin to be? (####) ");

                if (user.Password.ToString().Length == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nYour answer was invalid. Please try again!");
                    Console.WriteLine("Your choice must be 4 characters long");
                }
            }


            database.AddUser(user);
            database.SaveUsers();
        }

        private static void ExistingUser(UserDatabase database)
        {
            var userNameToSearchFor = PromptForString("\nWhat is your username? ");
            //var passwordToSearchFor = PromptForInteger("What is your pin number? ");

            //var user = new User();
            database.UserNameExists(userNameToSearchFor);
            var foundUserName = database.FindOneUser(userNameToSearchFor);

            // var userExists = database.Contains(database.FindOneUser(userNameToSearchFor));

            // if (database.(userNameToSearchFor) == true)
            // {
            //     Console.WriteLine("No such user!");
            // }
            // else
            // {

            //     //database.UserName
            //     // }
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to C#");

            // Database for Transactions
            var databaseTransaction = new TransactionDatabase();
            databaseTransaction.LoadTransactions();

            // Database for Users
            var databaseUser = new UserDatabase();
            databaseUser.LoadUsers();

            Console.Clear();
            DisplayGreeting();

            var keepGoing = true;

            // While the user hasn't said QUIT yet
            while (keepGoing)
            {
                Console.Write("\nWhat do you want to do?\n(C)reate Account\n(L)ogin to Account\n(Q)uit\n: ");
                var choice = Console.ReadLine().ToUpper();

                switch (choice)
                {
                    case "C":
                        AddUser(databaseUser);
                        break;
                    case "L":
                        ExistingUser(databaseUser);
                        break;
                    case "Q":
                        Console.WriteLine();
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("\nYour answer was invalid. Please try again!");
                        break;
                }

            }


        }
    }
}
