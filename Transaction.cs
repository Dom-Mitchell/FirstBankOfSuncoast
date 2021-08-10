using System;

namespace FirstBankOfSuncoast
{
    class Transaction
    {
        public string Name { get; set; } // Username
        public string Account { get; set; } // Checking or Savings
        public string Type { get; set; } // Withdrawal or Deposit
        public double Amount { get; set; }
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        // public string FormattedDate()
        // {
        //     return TimeStamp.ToString("dddd, MMMM dd, yyyy");
        // }

        // override public string ToString()
        // {
        //     return $"Name: {Name} Account Type: {Account} Action: {Type} Amount: {Amount} Time Stamp: {TimeStamp.ToString("dddd, MMMM dd, yyyy")}";
        // }

        public string Description()
        {
            switch (Type)
            {
                case "Withdraw":
                    return $"${Amount} was withdrawn by {Name} from {Account} account on {TimeStamp.ToString("dddd, MMMM dd, yyyy hh:mm tt")}.";
                case "Withdraw to Transfer":
                    return $"${Amount} was withdrawn by {Name} to transfer from {Account} account on {TimeStamp.ToString("dddd, MMMM dd, yyyy hh:mm tt")}.";
                case "Deposit":
                    return $"${Amount} was deposited by {Name} into {Account} account on {TimeStamp.ToString("dddd, MMMM dd, yyyy hh:mm tt")}.";
                case "Deposit to Transfer":
                    return $"{Amount} was deposited by {Name} to transfer into {Account} account on {TimeStamp.ToString("dddd, MMMM dd, yyyy hh:mm tt")}.";
                default:
                    return "\nYour answer was invalid. Please try again!";

            }

        }

    }

}
