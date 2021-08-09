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

        // static string PromptForString(string prompt)
        // {
        //     Console.Write(prompt);
        //     var userInput = Console.ReadLine();

        //     return userInput;
        // }

        // static int PromptForInteger(string prompt)
        // {
        //     Console.Write(prompt);
        //     int userInput;
        //     var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

        //     if (isThisGoodInput)
        //     {
        //         return userInput;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Sorry, that isn't a valid input, I'm using 0 as your answer.");
        //         return 0;
        //     }
        // }

        // static double PromptForDouble(string prompt)
        // {
        //     Console.Write(prompt);
        //     double userInput;
        //     var isThisGoodInput = Double.TryParse(Console.ReadLine(), out userInput);

        //     if (isThisGoodInput)
        //     {
        //         return userInput;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Sorry, that isn't a valid input, I'm using 0.0 as your answer.");
        //         return 0;
        //     }
        // }

        // private static void AddUser(UserDatabase database)
        // {
        //     var user = new User();
        //     var correctPinLength = false;
        //     var correctUserNameLength = false;



        //     while (!correctPinLength)
        //     {

        //     }


        //     database.AddUser(user);
        //     database.SaveUsers();
        // }

        // private static string ExistingUser(UserDatabase database)
        // {
        //     var userNameToSearchFor = PromptForString("\nWhat is your username? ");
        //     //var passwordToSearchFor = PromptForInteger("What is your pin number? ");

        //     database.UserExists(userNameToSearchFor);
        //     //newMenu();
        //     return userNameToSearchFor;
        //     // var passwordToSearchFor = PromptForInteger("What is your pin number? ");
        //     // database.UserPassWordExists(passwordToSearchFor);

        //     //var user = new User();
        //     // database.UserNameExists(userNameToSearchFor);

        // }

        // static void newMenu(string usersName)
        // {
        //     Console.Clear();
        //     DisplayGreeting();

        //     var keepGoing = true;

        //     var databaseTransaction = new TransactionDatabase();

        //     while (keepGoing)
        //     {
        //         Console.Write("\nWhat do you want to do?\n(W)ithdraw\n(D)eposit\n(B)alance Inquiry\n(Q)uit\n: ");
        //         var choice = Console.ReadLine().ToUpper();

        //         switch (choice)
        //         {
        //             case "W":
        //                 break;
        //             case "D":
        //                 makeDeposit(databaseTransaction, usersName);
        //                 break;
        //             case "B":
        //                 break;
        //             case "Q":
        //                 Console.WriteLine();
        //                 keepGoing = false;
        //                 break;
        //             default:
        //                 Console.WriteLine("\nYour answer was invalid. Please try again!");
        //                 break;
        //         }
        //     }

        // }

        // static void makeDeposit(TransactionDatabase database, string usersName)
        // {
        //     var transacion = new Transaction();

        //     transacion.Name = $"{usersName}";
        //     transacion.Account = PromptForString("Is this your Checking or Savings Account? ");
        //     transacion.Type = "Deposit";
        //     transacion.Amount = PromptForDouble("How much money would you like to add? ");
        //     transacion.TimeStamp = DateTime.Now;

        //     database.AddTransaction(transacion);
        //     database.SaveTransactions();
        // }

        static char PressAnyKey(string prompt)
        {
            Console.WriteLine(prompt);
            var keyPressed = Console.ReadKey().KeyChar;
            return keyPressed;
        }


        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to C#");

            // Database for Users
            var databaseUser = new UserDatabase();
            databaseUser.LoadUsers();

            Console.Clear();
            DisplayGreeting();

            var keepGoing = true;

            // While the user hasn't said QUIT yet
            while (keepGoing && !databaseUser.UserMatches)
            {
                Console.Write("\nWhat do you want to do?\n(C)reate Account\n(L)ogin to Account\n(Q)uit\n: ");
                var choices = Console.ReadLine().ToUpper();

                switch (choices)
                {
                    case "C":
                        databaseUser.CreateUser();
                        break;
                    case "L":
                        databaseUser.ExistingUser();
                        break;
                    case "Q":
                        Console.WriteLine();
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("\nYour answer was invalid. Please try again!");
                        break;
                }

                if (databaseUser.UserMatches)
                {
                    PressAnyKey("\nPress Any Key to Login! ");

                    Console.Clear();
                    DisplayGreeting();

                    // Database for Transactions
                    var databaseTransaction = new TransactionDatabase();
                    databaseTransaction.LoadTransactions();

                    Console.Write($"\nWhat do you want to do?\n(W)ithdraw\n(D)eposit\n(T)ransfer\n(B)alance Inquiry\n(L)ist All Transactions\n(Q)uit\n: ");
                    var loggedInChoices = Console.ReadLine().ToUpper();

                    switch (loggedInChoices)
                    {
                        case "W":
                            break;
                        case "D":
                            break;
                        case "T":
                            break;
                        case "B":
                            break;
                        case "L":
                            break;
                        default:
                            Console.WriteLine("\nYour answer was invalid. Please try again!");
                            break;
                    }
                }




            }


        }
    }
}
