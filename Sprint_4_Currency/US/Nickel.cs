using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_4_Currency
{
    public class Nickel : USCoin
    {
        public override int Year { get; }

        public override double MonetaryValue { get; set; }

        public override string Name { get; }

        public Nickel()
        {
            this.Year = DateTime.Now.Year;
            this.MintMark = USCoinMintMark.D;
            this.MonetaryValue = 0.05;
            this.Name = "Nickel";
        }

        public Nickel(USCoinMintMark mark, int year)
        {
            this.Year = year;
            this.MintMark = mark;
            this.MonetaryValue = 0.05;
            this.Name = "Nickel";
        }
    }
}
