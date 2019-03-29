using System;
using System.Collections.Generic;
using System.Text;

namespace WPFCurrency
{
    public interface ICurrency
    {
        double MonetaryValue { get; set; }
        string Name { get; }

        string About();
    }

    public interface ICoin : ICurrency
    {
        int Year { get; }
    }

    public interface IBankNote
    {
        int Year { get; }
    }
}
