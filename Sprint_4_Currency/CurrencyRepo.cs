using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_4_Currency
{
    public class CurrencyRepo : ICurrencyRepo
    {
        public List<ICoin> Coins { get; set; }


        public CurrencyRepo()
        {
            this.Coins = new List<ICoin>();
        }

        public int GetCoinCount()
        {
            return this.Coins.Count;
        }

        public string About()
        {
            throw new NotImplementedException();
        }

        public void AddCoin(ICoin c)
        {
            this.Coins.Add(c);
        }

        public ICurrencyRepo MakeChange(double Amount)
        {
            throw new NotImplementedException();
        }

        public ICurrencyRepo MakeChange(double AmountTendered, double TotalCost)
        {
            throw new NotImplementedException();
        }

        public void RemoveCoin(ICoin c)
        {
            this.Coins.Remove(c);
        }

        public double TotalValue()
        {
            double total = 0;

            foreach (var c in this.Coins)
            {
                total += c.MonetaryValue;
            }

            return total;
        }

        public static ICurrencyRepo CreateChange(double Amount)
        {
            return null;
        }

        public static ICurrencyRepo CreateChange(double AmountTendered, double TotalCost)
        {
            return null;
        }
    }
}
