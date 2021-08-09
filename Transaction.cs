using System;

namespace FirstBankOfSuncoast
{
    class Transaction
    {
        public string Name { get; set; } // Username
        public string Account { get; set; } // Checking or Savings
        public string Type { get; set; } // Withdrawal or Deposit
        public double Amount { get; set; }
        public DateTime TimeStamp { get; set; }

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
                    return $"{Amount} was withdrawn by {Name} from {Account} account at {TimeStamp}.";
                case "Withdraw to Transfer":
                    return $"{Amount} was withdrawn by {Name} for transfer from {Account} account at {TimeStamp}.";
                case "Deposit":
                    return $"{Amount} was deposited by {Name} into {Account} account at {TimeStamp}.";
                case "Deposit to Transfer":
                    return $"{Amount} was deposited by {Name} for transfer into {Account} account at {TimeStamp}.";
                default:
                    return "\nYour answer was invalid. Please try again!";

            }

        }

    }

}
