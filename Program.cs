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

        static void DisplayExit()
        {
            // Ascii text from https://www.ascii-art-generator.org/ & Sun from https://textart.io/art/tag/sun/1
            Console.WriteLine($"{"#######                             ".Pastel(Color.LightSkyBlue)}  {" #     #               ###  ".Pastel(Color.SeaGreen)}{@"            \       |         /         ".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{"   #    #    #   ##   #    # #    # ".Pastel(Color.LightSkyBlue)}  {"  #   #   ####  #    # ###  ".Pastel(Color.SeaGreen)}{@"  .          .      |        .        . ".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{"   #    #    #  #  #  ##   # #   #  ".Pastel(Color.LightSkyBlue)}  {"   # #   #    # #    # ###  ".Pastel(Color.SeaGreen)}{@"    .         \             /       .   ".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{"   #    ###### #    # # #  # ####   ".Pastel(Color.LightSkyBlue)}  {"    #    #    # #    #  #   ".Pastel(Color.SeaGreen)}{@"      '  .     \    |      /      .     ".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{"   #    #    # ###### #  # # #  #   ".Pastel(Color.LightSkyBlue)}  {"    #    #    # #    #      ".Pastel(Color.SeaGreen)}{@"            .".Pastel(Color.OrangeRed)} {" ,+~'`^`'~+,".Pastel(Color.DarkOrange)}{@"/   , '".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{"   #    #    # #    # #   ## #   #  ".Pastel(Color.LightSkyBlue)}  {"    #    #    # #    # ###  ".Pastel(Color.SeaGreen)}{@"             .'           '.".Pastel(Color.DarkOrange)}{"'".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{"   #    #    # #    # #    # #    # ".Pastel(Color.LightSkyBlue)}  {"    #     ####   ####  ###  ".Pastel(Color.SeaGreen)}{@"   --- -- -".Pastel(Color.OrangeRed)} {@"/               \".Pastel(Color.DarkOrange)} {"- -- ---  ".Pastel(Color.OrangeRed)}\n");
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

        // public static void Exit()
        // {
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

            // DisplayExit();

            UserDatabase databaseUser = MainMenu();
            LoggedInMenu(databaseUser);

        }

        private static void LoggedInMenu(UserDatabase databaseUser)
        {
            // Database for Transactions
            var databaseTransaction = new TransactionDatabase();
            databaseTransaction.LoadTransactions();

            var promptAgain = true;

            while (promptAgain)
            {
                if (databaseUser.UserMatches)
                {
                    Console.Clear();
                    DisplayGreeting();

                    Console.Write($"\nWelcome, {databaseUser.SingularUser.UserName}!\n\nWhat do you want to do?\n(W)ithdraw\n(D)eposit\n(T)ransfer\n(B)alance Inquiry\n(L)ist All Transactions\n(S)ign Out\n(Q)uit\n: ");
                    var loggedInChoices = Console.ReadLine().ToUpper();

                    switch (loggedInChoices)
                    {
                        case "W":
                            Console.Clear();
                            DisplayGreeting();
                            Withdraw(databaseUser, databaseTransaction);
                            PressAnyKey("\nPress Any Key to Continue! ");
                            break;
                        case "D":
                            Console.Clear();
                            DisplayGreeting();
                            Deposit(databaseUser, databaseTransaction);
                            PressAnyKey("\nPress Any Key to Continue! ");
                            break;
                        case "T":
                            Console.Clear();
                            DisplayGreeting();
                            Transfer(databaseUser, databaseTransaction);
                            PressAnyKey("\nPress Any Key to Continue! ");
                            break;
                        case "B":
                            Console.Clear();
                            DisplayGreeting();
                            BalaneInquiry(databaseUser, databaseTransaction);
                            PressAnyKey("\nPress Any Key to Continue! ");
                            break;
                        case "L":
                            Console.Clear();
                            DisplayGreeting();
                            databaseTransaction.ListAllTransactions(databaseUser.SingularUser);
                            PressAnyKey("\nPress Any Key to Continue! ");
                            break;
                        case "S":
                            databaseUser = MainMenu();
                            break;
                        case "Q":
                            Console.Clear();
                            DisplayExit();
                            promptAgain = false;
                            break;
                        default:
                            Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                            PressAnyKey("\nPress Any Key to Continue! ");
                            Console.Clear();
                            DisplayGreeting();
                            break;
                    }
                }
                // PressAnyKey("\nPress Any Key to Continue! ");
            }
        }

        private static UserDatabase MainMenu()
        {
            // Database for Users
            var databaseUser = new UserDatabase();
            databaseUser.LoadUsers();

            var keepGoing = true;

            Console.Clear();
            DisplayGreeting();

            // While the user hasn't said QUIT yet
            while (keepGoing && !databaseUser.UserMatches)
            {
                Console.Write("\nWhat do you want to do?\n(C)reate Account\n(L)ogin to Account\n(Q)uit\n: ");
                var choices = Console.ReadLine().ToUpper();

                switch (choices)
                {
                    case "C":
                        databaseUser.CreateUser();
                        PressAnyKey("\nPress Any Key to Continue! ");
                        Console.Clear();
                        DisplayGreeting();
                        break;
                    case "L":
                        databaseUser.ExistingUser();
                        PressAnyKey("\nPress Any Key to Continue! ");
                        break;
                    case "Q":
                        Console.Clear();
                        DisplayExit();
                        Environment.Exit(0);
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                        PressAnyKey("\nPress Any Key to Continue! ");
                        Console.Clear();
                        DisplayGreeting();
                        break;
                }

            }

            return databaseUser;
        }

        private static void BalaneInquiry(UserDatabase user, TransactionDatabase transactions)
        {
            var correctChoice = false;
            while (!correctChoice)
            {
                Console.WriteLine($"\nWould you like to view your Checking or Savings Account, {user.SingularUser.UserName}? (Checking/Savings) ");
                var userSelection = Console.ReadLine().ToLower();

                if (userSelection == "c" || userSelection == "checking")
                {
                    Console.WriteLine($"\nChecking Balance: ${transactions.checkingTotal(user.SingularUser)}");
                    break;
                }
                else if (userSelection == "s" || userSelection == "savings")
                {
                    Console.WriteLine($"\nSavings Balance: ${transactions.savingsTotal(user.SingularUser)}");
                    break;
                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                }

            }
        }

        private static void Transfer(UserDatabase user, TransactionDatabase transactions)
        {
            var correctChoice = false;
            while (!correctChoice)
            {
                Console.WriteLine($"\nWould you like to transfer from your Checking or Savings Account, {user.SingularUser.UserName}? (Checking/Savings) ");
                var userSelection = Console.ReadLine().ToLower();

                if (userSelection == "c" || userSelection == "checking")
                {
                    transactions.TransferToSaving(user.SingularUser);
                }
                else if (userSelection == "s" || userSelection == "savings")
                {
                    transactions.TransferToChecking(user.SingularUser);
                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                }
                break;

            }
        }

        private static void Deposit(UserDatabase user, TransactionDatabase transactions)
        {
            var correctChoice = false;
            while (!correctChoice)
            {
                Console.WriteLine($"\nWould you like to deposit to your Checking or Savings Account, {user.SingularUser.UserName}? (Checking/Savings) ");
                var userSelection = Console.ReadLine().ToLower();

                if (userSelection == "c" || userSelection == "checking")
                {
                    transactions.AddDepositToChecking(user.SingularUser);
                    break;
                }
                else if (userSelection == "s" || userSelection == "savings")
                {
                    transactions.AddDepositToSavings(user.SingularUser);
                    break;
                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                }
            }
        }

        private static void Withdraw(UserDatabase user, TransactionDatabase transactions)
        {
            var correctChoice = false;
            while (!correctChoice)
            {
                Console.WriteLine($"\nWould you like to withdraw to your Checking or Savings Account, {user.SingularUser.UserName}? (Checking/Savings) ");
                var userSelection = Console.ReadLine().ToLower();

                if (userSelection == "c" || userSelection == "checking")
                {
                    transactions.AddWithdrawFromChecking(user.SingularUser);
                    break;
                }
                else if (userSelection == "s" || userSelection == "savings")
                {
                    transactions.AddWithdrawFromSavings(user.SingularUser);
                    break;
                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                }

            }
        }
    }
}
