using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_4_Currency
{
    public class Dime : USCoin
    {
        public override int Year { get; }

        public override double MonetaryValue { get; set; }

        public override string Name { get; }

        public Dime()
        {
            this.Year = DateTime.Now.Year;
            this.MintMark = USCoinMintMark.D;
            this.MonetaryValue = 0.10;
            this.Name = "Dime";
        }

        public Dime(USCoinMintMark mark, int year)
        {
            this.Year = year;
            this.MintMark = mark;
            this.MonetaryValue = 0.10;
            this.Name = "Dime";
        }
    }
}
