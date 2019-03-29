using System;
using System.Collections.Generic;
using System.Text;

namespace WPFCurrency
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
            ICurrencyRepo total = new CurrencyRepo();
            
            while(Amount > 0)
            {
                if (Amount - 1 >= 0)
                {
                    total.AddCoin(new DollarCoin());
                    Amount -= 1;
                }
                else if (Amount - .5 >= 0)
                {
                    total.AddCoin(new HalfDollar());
                    Amount -= .5;
                }
                else if (Amount - 0.25 >= 0)
                {
                    total.AddCoin(new Quarter());
                    Amount -= 0.25;
                }
                else if (Amount - 0.10 >= 0)
                {
                    total.AddCoin(new Dime());
                    Amount -= .1;
                }
                else if (Amount - 0.05 >= 0)
                {
                    total.AddCoin(new Nickel());
                    Amount -= 0.05;
                }
                else
                {
                    total.AddCoin(new Penny());
                    Amount -= 0.01;
                }
            }

            return total;
        }

        public static ICurrencyRepo CreateChange(double AmountTendered, double TotalCost)
        {
            return null;
        }
    }
}
