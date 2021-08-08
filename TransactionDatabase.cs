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

        public void AddTransaction(Transaction newTransaction)
        {
            Transactions.Add(newTransaction);
        }

    }
}
