using System;

namespace FirstBankOfSuncoast
{
    class Transaction
    {
        public string Name { get; set; }
        public string Account { get; set; } // Checking or Savings
        public string Type { get; set; } // Withdrawal or Deposit
        public double Amount { get; set; }
        public DateTime TimeStamp { get; set; }

        // public string FormattedDate()
        // {
        //     return TimeStamp.ToString("dddd, MMMM dd, yyyy");
        // }

        override public string ToString()
        {
            return $"Name: {Name} Account Type: {Account} Action: {Type} Amount: {Amount} Time Stamp: {TimeStamp.ToString("dddd, MMMM dd, yyyy")}";
        }

    }

}
