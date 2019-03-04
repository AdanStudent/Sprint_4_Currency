using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_4_Currency
{
    public abstract class Coin : ICoin
    {
        public abstract int Year { get; set; }
        public abstract double MonetaryValue { get; set; }
        public abstract string Name { get; set; }

        public abstract string About();

        public Coin()
        {

        }
    }
}
