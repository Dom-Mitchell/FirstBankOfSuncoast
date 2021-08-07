using System;

namespace FirstBankOfSuncoast
{
    class Transaction
    {
        public string Account { get; set; } // Checking or Savings
        public string Type { get; set; } // Withdrawal or Deposit
        public int Amount { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;
    }
}
