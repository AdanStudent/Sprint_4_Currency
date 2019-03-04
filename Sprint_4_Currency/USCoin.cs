using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_4_Currency
{
    public enum USCoinMintMark { P, D, S, W }
    public abstract class USCoin : ICoin
    {
        public USCoinMintMark MintMark { get; set; }
        public abstract int Year { get; }
        public abstract double MonetaryValue { get; set; }
        public abstract string Name { get; }

        public string About()
        {
            return $"US {this.Name} is from {this.Year}. It is worth ${this.MonetaryValue}. It was made in {GetMintNameFromMark(this.MintMark)}";
        }

        public static string GetMintNameFromMark(USCoinMintMark mark)
        {
            string mintName = "";
            switch (mark)
            {
                case USCoinMintMark.P:
                    mintName = "Philadephia";
                    break;

                case USCoinMintMark.D:
                    mintName = "Denver";
                    break;

                case USCoinMintMark.S:
                    mintName = "San Francisco";
                    break;

                case USCoinMintMark.W:
                    mintName = "West Point";
                    break;
            }

            return mintName;
        }
    

        public USCoin()
        {

        }
            
    }
}
