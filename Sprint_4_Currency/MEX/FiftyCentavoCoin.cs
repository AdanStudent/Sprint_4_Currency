
using System;

namespace Sprint_4_Currency.MEX
{
    public class FiftyCentavoCoin : Centavo
    {
        public override int Year { get; }

        public override double MonetaryValue { get; set; }

        public override string Name { get; }

        public FiftyCentavoCoin()
        {
            this.Year = DateTime.Now.Year;
            this.MonetaryValue = 0.50;
            this.Name = "Cincuenta";
        }
    }
}
