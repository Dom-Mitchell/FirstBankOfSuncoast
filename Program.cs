using System;
using System.Collections.Generic;
using System.Drawing;
using Pastel;

namespace FirstBankOfSuncoast
{
    class Transaction
    {
        public int Amount { get; set; }
        public string Type { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Account { get; set; }

        private List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }

    class Program
    {

        static void DisplayGreeting()
        {
            Console.WriteLine($"  #####   #####     ######                                       {@"            \       |         /         ".Pastel(Color.Orange)});
            Console.WriteLine($" #     # #     #    #     #   ##   #    # #    # # #    #  ####  {@"  .          .      |        .        . ".Pastel(Color.Orange)});
            Console.WriteLine($" #       #          #     #  #  #  ##   # #   #  # ##   # #    # {@"    .         \             /       .   ".Pastel(Color.Orange)});
            Console.WriteLine($"  #####  #          ######  #    # # #  # ####   # # #  # #      {@"      '  .     \    |      /      .     ".Pastel(Color.Orange)});
            Console.WriteLine($"       # #          #     # ###### #  # # #  #   # #  # # #  ### {@"            .  ,+~'`^`'~+,/   , '       ".Pastel(Color.Orange)});
            Console.WriteLine($" #     # #     #    #     # #    # #   ## #   #  # #   ## #    # {@"             .'           '.'           ".Pastel(Color.Orange)});
            Console.WriteLine($"  #####   #####     ######  #    # #    # #    # # #    #  ####  {@"   --- -- - /               \ - -- ---  ".Pastel(Color.Orange)});
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to C#");
            DisplayGreeting();
        }
    }
}
