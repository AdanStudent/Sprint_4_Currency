﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_4_Currency.MEX
{
    public class CentavoCoin : Centavo
    {
        public override int Year { get; }

        public override double MonetaryValue { get; set; }

        public override string Name { get; }

        public CentavoCoin()
        {
            this.Year = DateTime.Now.Year;
            this.MonetaryValue = 1;
            this.Name = "1 Peso Centavo";
        }
    }
}
