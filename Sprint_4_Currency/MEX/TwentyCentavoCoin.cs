using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_4_Currency.MEX
{
    public class TwentyCentavoCoin : Centavo
    {
        public override int Year { get; }

        public override double MonetaryValue { get; set; }

        public override string Name { get; }

        public TwentyCentavoCoin()
        {
            this.Year = DateTime.Now.Year;
            this.MonetaryValue = 10;
            this.Name = "20 Peso Centavo";
        }
    }
}
