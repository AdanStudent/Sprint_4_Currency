using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint_4_Currency
{
    public interface ICurrencyRepo
    {
        List<ICoin> Coins { get; set; }

        string About();
        void AddCoin(ICoin c);
        int GetCoinCount();
        ICurrencyRepo MakeChange(double Amount);
        ICurrencyRepo MakeChange(double AmountTendered, double TotalCost);

        void RemoveCoin(ICoin c);
        double TotalValue();
    }
}
