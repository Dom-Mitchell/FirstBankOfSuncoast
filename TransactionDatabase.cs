using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using Pastel;

namespace FirstBankOfSuncoast
{
    class TransactionDatabase
    {
        private List<Transaction> Transactions { get; set; } = new List<Transaction>();

        private string FileName = "Transactions.csv";

        public void LoadTransactions()
        {
            if (File.Exists(FileName))
            {
                var fileReader = new StreamReader(FileName);

                var csvReader = new CsvReader(fileReader, CultureInfo.InvariantCulture);

                // Replace our BLANK list of employees with the ones that are in the CSV file
                Transactions = csvReader.GetRecords<Transaction>().ToList();

                fileReader.Close();
            }
        }

        public void SaveTransactions()
        {
            var fileWriter = new StreamWriter(FileName);

            var csvWriter = new CsvWriter(fileWriter, CultureInfo.InvariantCulture);

            csvWriter.WriteRecords(Transactions);

            fileWriter.Close();
        }

        public double savingsTotal(User user)
        {
            var depositSum = Transactions.Where(transaction => (transaction.Type == "Deposit" || transaction.Type == "Deposit to Transfer") && transaction.Name == user.UserName && transaction.Account == "Savings").Sum(transaction => transaction.Amount);
            var withdrawalSum = Transactions.Where(transaction => (transaction.Type == "Withdraw" || transaction.Type == "Withdraw to Transfer") && transaction.Name == user.UserName && transaction.Account == "Savings").Sum(transaction => transaction.Amount);

            var savingsBalance = depositSum - withdrawalSum;

            return savingsBalance;
        }

        public double checkingTotal(User user)
        {
            var depositSum = Transactions.Where(transaction => (transaction.Type == "Deposit" || transaction.Type == "Deposit to Transfer") && transaction.Name == user.UserName && transaction.Account == "Checking").Sum(transaction => transaction.Amount);
            var withdrawalSum = Transactions.Where(transaction => (transaction.Type == "Withdraw" || transaction.Type == "Withdraw to Transfer") && transaction.Name == user.UserName && transaction.Account == "Checking").Sum(transaction => transaction.Amount);

            var checkingBalance = depositSum - withdrawalSum;

            return checkingBalance;
        }

        public void AddDepositToSavings(User user)
        {
            var newTransaction = new Transaction();

            newTransaction.Name = user.UserName;
            newTransaction.Account = "Savings";
            newTransaction.Type = "Deposit";

            var madeDeposit = false;
            while (!madeDeposit)
            {
                Console.WriteLine($"\nHow much money would you like to Deposit to your Savings Account, {user.UserName}? ");

                var money = 0.0;
                var isThisGoodInput = Double.TryParse(Console.ReadLine(), out money);

                if (isThisGoodInput && money > 0)
                {
                    newTransaction.Amount = money;
                    Transactions.Add(newTransaction);
                    SaveTransactions();

                    Console.WriteLine($"\nFunds Deposited to {user.UserName}'s Savings Account!");
                    Console.WriteLine($"Savings Balance: ${savingsTotal(user)}");
                    break;

                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                    Console.WriteLine($"{"Your choice must be greater than 0".Pastel(Color.Red)}");
                }

            }


        }

        public void AddDepositToChecking(User user)
        {
            var newTransaction = new Transaction();

            newTransaction.Name = user.UserName;
            newTransaction.Account = "Checking";
            newTransaction.Type = "Deposit";

            var madeDeposit = false;
            while (!madeDeposit)
            {
                Console.WriteLine($"\nHow much money would you like to Deposit to your Checking Account, {user.UserName}? ");

                var money = 0.0;
                var isThisGoodInput = Double.TryParse(Console.ReadLine(), out money);

                if (isThisGoodInput && money > 0)
                {
                    newTransaction.Amount = money;
                    Transactions.Add(newTransaction);
                    SaveTransactions();

                    Console.WriteLine($"\nFunds Deposited to {user.UserName}'s Checking Account!");
                    Console.WriteLine($"Checking Balance: ${checkingTotal(user)}");
                    break;

                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                    Console.WriteLine($"{"Your choice must be greater than 0".Pastel(Color.Red)}");
                }

            }


        }


        public void AddWithdrawFromSavings(User user)
        {
            var newTransaction = new Transaction();

            newTransaction.Name = user.UserName;
            newTransaction.Account = "Savings";
            newTransaction.Type = "Withdraw";

            var madeWithdraw = false;
            while (!madeWithdraw)
            {
                Console.WriteLine($"\nHow much money would you like to Withdraw from your Savings Account, {user.UserName}? ");

                var money = 0.0;
                var isThisGoodInput = Double.TryParse(Console.ReadLine(), out money);

                if (isThisGoodInput && money > 0)
                {
                    if (((savingsTotal(user) - money) >= 0))
                    {
                        newTransaction.Amount = money;
                        Transactions.Add(newTransaction);
                        SaveTransactions();

                        Console.WriteLine($"\nFunds Withdrawn from {user.UserName}'s Savings Account!");
                        Console.WriteLine($"Savings Balance: ${savingsTotal(user)}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                        Console.WriteLine($"{"SC Banking does not support overdraw at this time...".Pastel(Color.Red)}");
                    }

                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                    Console.WriteLine($"{"Your choice must be greater than 0".Pastel(Color.Red)}");
                }

            }


        }

        public void AddWithdrawFromChecking(User user)
        {
            var newTransaction = new Transaction();

            newTransaction.Name = user.UserName;
            newTransaction.Account = "Checking";
            newTransaction.Type = "Withdraw";

            var madeWithdraw = false;
            while (!madeWithdraw)
            {
                Console.WriteLine($"\nHow much money would you like to Withdraw from your Checking Account, {user.UserName}? ");

                var money = 0.0;
                var isThisGoodInput = Double.TryParse(Console.ReadLine(), out money);

                if (isThisGoodInput && money > 0)
                {
                    if (((checkingTotal(user) - money) >= 0))
                    {
                        newTransaction.Amount = money;
                        Transactions.Add(newTransaction);
                        SaveTransactions();

                        Console.WriteLine($"\nFunds Withdrawn from {user.UserName}'s Checking Account!");
                        Console.WriteLine($"Checking Balance: ${checkingTotal(user)}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                        Console.WriteLine($"{"SC Banking does not support overdraw at this time...".Pastel(Color.Red)}");
                    }

                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                    Console.WriteLine($"{"Your choice must be greater than 0".Pastel(Color.Red)}");
                }

            }


        }

        public void TransferToChecking(User user)
        {
            var madeTransfer = false;
            while (madeTransfer)
            {
                Console.WriteLine($"\nHow much money would you like to Transfer from your Savings into your Checking Account, {user.UserName}? ");

                var money = 0.0;
                var isThisGoodInput = Double.TryParse(Console.ReadLine(), out money);

                if (isThisGoodInput && money > 0)
                {
                    if (((savingsTotal(user) - money) >= 0))
                    {
                        var newTransaction = new Transaction();
                        newTransaction.Name = user.UserName;
                        newTransaction.Account = "Savings";
                        newTransaction.Type = "Withdraw to Transfer";
                        newTransaction.Amount = money;
                        Transactions.Add(newTransaction);
                        SaveTransactions();

                        Console.WriteLine($"Funds Withdrawn from {user.UserName}'s Savings Account");

                        var secondTransaction = new Transaction();
                        secondTransaction.Name = user.UserName;
                        secondTransaction.Account = "Checking";
                        secondTransaction.Type = "Deposit to Transfer";
                        secondTransaction.Amount = money;
                        Transactions.Add(secondTransaction);
                        SaveTransactions();

                        Console.WriteLine($"Funds Deposited to {user.UserName}'s Checking Account.");
                        Console.WriteLine($"Checking Balance: ${checkingTotal(user)}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                        Console.WriteLine($"{"SC Banking does not support overdraw at this time...".Pastel(Color.Red)}");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                    Console.WriteLine($"{"Your choice must be greater than 0".Pastel(Color.Red)}");
                }

            }

        }

        public void TransferToSaving(User user)
        {
            var madeTransfer = false;
            while (madeTransfer)
            {
                Console.WriteLine($"\nHow much money would you like to Transfer from your Checking into your Savings Account, {user.UserName}? ");

                var money = 0.0;
                var isThisGoodInput = Double.TryParse(Console.ReadLine(), out money);

                if (isThisGoodInput && money > 0)
                {
                    if (((checkingTotal(user) - money) >= 0))
                    {
                        var newTransaction = new Transaction();
                        newTransaction.Name = user.UserName;
                        newTransaction.Account = "Checking";
                        newTransaction.Type = "Withdraw to Transfer";
                        newTransaction.Amount = money;
                        Transactions.Add(newTransaction);
                        SaveTransactions();

                        Console.WriteLine($"Funds Withdrawn from {user.UserName}'s Checking Account");

                        var secondTransaction = new Transaction();
                        secondTransaction.Name = user.UserName;
                        secondTransaction.Account = "Savings";
                        secondTransaction.Type = "Deposit to Transfer";
                        secondTransaction.Amount = money;
                        Transactions.Add(secondTransaction);
                        SaveTransactions();

                        Console.WriteLine($"Funds Deposited to {user.UserName}'s Savings Account.");
                        Console.WriteLine($"Savings Balance: ${checkingTotal(user)}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                        Console.WriteLine($"{"SC Banking does not support overdraw at this time...".Pastel(Color.Red)}");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                    Console.WriteLine($"{"Your choice must be greater than 0".Pastel(Color.Red)}");
                }

            }

        }

        public void ListAllTransactions(User user)
        {
            Console.WriteLine();
            foreach (var Transaction in Transactions.Where(Transaction => Transaction.Name == user.UserName))
            {
                Console.WriteLine(Transaction.Description());
            }
            Console.WriteLine();
        }

    }
}
