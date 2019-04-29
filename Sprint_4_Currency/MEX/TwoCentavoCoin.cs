using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_4_Currency.MEX
{
    public class TwoCentavoCoin : Centavo
    {
        public override int Year { get; }

        public override double MonetaryValue { get; set; }

        public override string Name { get; }

        public TwoCentavoCoin()
        {
            this.Year = DateTime.Now.Year;
            this.MonetaryValue = 2;
            this.Name = "2 Peso Centavo";
        }
    }
}
