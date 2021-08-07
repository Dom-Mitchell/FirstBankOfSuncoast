using System;

namespace FirstBankOfSuncoast
{
    class Transaction
    {
        public string Type { get; set; }
        public int Amount { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Account { get; set; }
    }
}
