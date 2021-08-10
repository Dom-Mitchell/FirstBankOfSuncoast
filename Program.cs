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

        static char PressAnyKey(string prompt)
        {
            Console.WriteLine(prompt);
            var keyPressed = Console.ReadKey().KeyChar;
            return keyPressed;
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
                        PressAnyKey("\nPress Any Key to Login! ");
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
                            PressAnyKey("\nPress Any Key to Sign Out! ");
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
                    break;
                }
                else if (userSelection == "s" || userSelection == "savings")
                {
                    transactions.TransferToChecking(user.SingularUser);
                    break;
                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                }
            }
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

        static void Main(string[] args)
        {
            UserDatabase databaseUser = MainMenu();
            LoggedInMenu(databaseUser);

        }

    }
}
