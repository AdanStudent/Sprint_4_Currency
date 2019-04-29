using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_4_Currency.MEX
{
    public abstract class Centavo : ICoin
    {
        public abstract int Year { get; }

        public abstract double MonetaryValue { get; set; }

        public abstract string Name { get; }

        public string About()
        {
            return $"{this.Name} is from {this.Year}. It is worth Mex${this.MonetaryValue}";
        }

        public Centavo()
        {

        }
    }
}
