using System;
using System.Collections.Generic;
using System.Text;

namespace WPFCurrency
{
    [Serializable]

    public class HalfDollar : USCoin
    {
        public override int Year { get; }

        public override double MonetaryValue { get; set; }

        public override string Name { get; }

        public HalfDollar()
        {
            this.Year = DateTime.Now.Year;
            this.MintMark = USCoinMintMark.D;
            this.MonetaryValue = 0.50;
            this.Name = "HalfDollar";
        }

        public HalfDollar(USCoinMintMark mark, int year)
        {
            this.Year = year;
            this.MintMark = mark;
            this.MonetaryValue = 0.50;
            this.Name = "HalfDollar";
        }
    }
}
