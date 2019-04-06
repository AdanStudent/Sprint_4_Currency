using System;
using System.Collections.Generic;
using System.Text;

namespace WPFCurrency
{
    [Serializable]

    public class DollarCoin : USCoin
    {
        public override int Year { get; }

        public override double MonetaryValue { get; set; }

        public override string Name { get; }

        public DollarCoin()
        {
            this.Year = DateTime.Now.Year;
            this.MintMark = USCoinMintMark.D;
            this.MonetaryValue = 1.00;
            this.Name = "DollarCoin";
        }

        public DollarCoin(USCoinMintMark mark, int year)
        {
            this.Year = year;
            this.MintMark = mark;
            this.MonetaryValue = 1.00;
            this.Name = "DollarCoin";
        }
    }
}
