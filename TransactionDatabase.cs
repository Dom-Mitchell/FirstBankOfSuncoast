using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

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

        public void AddDepositToSavings(User user)
        {
            var newTransaction = new Transaction();

            newTransaction.Name = user.UserName;
            newTransaction.Account = "Savings";
            newTransaction.Type = "Deposit";

            var madeDeposit = false;
            while (!madeDeposit)
            {
                Console.WriteLine($"How much money would you like to Deposit to your Savings, {newTransaction.Name}?");

                var money = 0.0;
                var isThisGoodInput = Double.TryParse(Console.ReadLine(), out money);

                if (isThisGoodInput && money > 0)
                {
                    newTransaction.Amount = money;
                    Transactions.Add(newTransaction);
                    SaveTransactions();

                    Console.WriteLine($"Funds Deposited to {newTransaction.Name}'s Savings Account!");
                    Console.WriteLine($"Savings Balance: {savingsTotal(user)}");
                    break;

                }
                else
                {
                    Console.WriteLine("\nYour answer was invalid. Please try again!");
                    Console.WriteLine("Your choice must be greater than 0");
                }

            }


        }


        public void AddWithdrawFromSavings(User user)
        {
            var newTransaction = new Transaction();

            newTransaction.Name = user.UserName;
            newTransaction.Account = "Savings";
            newTransaction.Type = "Withdraw";

            var madeDeposit = false;
            while (!madeDeposit)
            {
                Console.WriteLine($"How much money would you like to Withdraw from your Savings, {newTransaction.Name}?");

                var money = 0.0;
                var isThisGoodInput = Double.TryParse(Console.ReadLine(), out money);

                if (isThisGoodInput && money > 0)
                {
                    newTransaction.Amount = money;
                    Transactions.Add(newTransaction);
                    SaveTransactions();

                    Console.WriteLine($"Funds Withdrawn from {newTransaction.Name}'s Savings Account!");
                    Console.WriteLine($"Savings Balance: {savingsTotal(user)}");
                    break;

                }
                else
                {
                    Console.WriteLine("\nYour answer was invalid. Please try again!");
                    Console.WriteLine("Your choice must be greater than 0");
                }

            }


        }

        public void ListAllTransactions(User user)
        {
            foreach (var Transaction in Transactions.Where(Transaction => Transaction.Name == user.UserName))
            {
                Console.WriteLine(Transaction.Description());
            }
            Console.WriteLine();
        }

    }
}
