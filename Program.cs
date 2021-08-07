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
            // Console.WriteLine($@"  #####   #####     ######                                       {@"            \       |         /         ".Pastel(Color.DarkOrange)}");
            // Console.WriteLine($@" #     # #     #    #     #   ##   #    # #    # # #    #  ####  {@"  .          .      |        .        . ".Pastel(Color.DarkOrange)}");
            // Console.WriteLine($@" #       #          #     #  #  #  ##   # #   #  # ##   # #    # {@"    .         \             /       .   ".Pastel(Color.DarkOrange)}");
            // Console.WriteLine($@"  #####  #          ######  #    # # #  # ####   # # #  # #      {@"      '  .     \    |      /      .     ".Pastel(Color.DarkOrange)}");
            // Console.WriteLine($@"       # #          #     # ###### #  # # #  #   # #  # # #  ### {@"            .  ,+~'`^`'~+,/   , '       ".Pastel(Color.DarkOrange)}");
            // Console.WriteLine($@" #     # #     #    #     # #    # #   ## #   #  # #   ## #    # {@"             .'           '.'           ".Pastel(Color.DarkOrange)}");
            // Console.WriteLine($@"  #####   #####     ######  #    # #    # #    # # #    #  ####  {@"   --- -- - /               \ - -- ---  ".Pastel(Color.DarkOrange)}");

            Console.WriteLine($"{"  #####   #####   ".Pastel(Color.LightSkyBlue)}  {"######                                       ".Pastel(Color.SeaGreen)}{@"            \       |         /         ".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{" #     # #     #  ".Pastel(Color.LightSkyBlue)}  {"#     #   ##   #    # #    # # #    #  ####  ".Pastel(Color.SeaGreen)}{@"  .          .      |        .        . ".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{" #       #        ".Pastel(Color.LightSkyBlue)}  {"#     #  #  #  ##   # #   #  # ##   # #    # ".Pastel(Color.SeaGreen)}{@"    .         \             /       .   ".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{"  #####  #        ".Pastel(Color.LightSkyBlue)}  {"######  #    # # #  # ####   # # #  # #      ".Pastel(Color.SeaGreen)}{@"      '  .     \    |      /      .     ".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{"       # #        ".Pastel(Color.LightSkyBlue)}  {"#     # ###### #  # # #  #   # #  # # #  ### ".Pastel(Color.SeaGreen)}{@"            .".Pastel(Color.OrangeRed)} {" ,+~'`^`'~+,".Pastel(Color.DarkOrange)}{@"/   , '".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{" #     # #     #  ".Pastel(Color.LightSkyBlue)}  {"#     # #    # #   ## #   #  # #   ## #    # ".Pastel(Color.SeaGreen)}{@"             .'           '.".Pastel(Color.DarkOrange)}{"'".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"{"  #####   #####   ".Pastel(Color.LightSkyBlue)}  {"######  #    # #    # #    # # #    #  ####  ".Pastel(Color.SeaGreen)}{@"   --- -- -".Pastel(Color.OrangeRed)} {@"/               \".Pastel(Color.DarkOrange)} {"- -- ---  ".Pastel(Color.OrangeRed)}");
            Console.WriteLine($"\n{@"############################################################################################################".Pastel(Color.LightSlateGray)}");
            Console.WriteLine($"{@"############################################################################################################".Pastel(Color.LightSlateGray)}");
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to C#");
            DisplayGreeting();
        }
    }
}
