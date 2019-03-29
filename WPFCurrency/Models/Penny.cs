using System;
using System.Collections.Generic;
using System.Text;

namespace WPFCurrency
{
    public class Penny : USCoin
    {
        public override int Year { get; }

        public override double MonetaryValue { get; set; }

        public override string Name { get; }

        public Penny()
        {
            this.Year = DateTime.Now.Year;
            this.MintMark = USCoinMintMark.D;
            this.MonetaryValue = 0.01;
            this.Name = "Penny";
        }

        public Penny(USCoinMintMark mark, int year)
        {
            this.Year = year;
            this.MintMark = mark;
            this.MonetaryValue = 0.01;
            this.Name = "Penny";
        }
    }
}
