using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPFCurrency.ViewModels;

namespace WPFCurrency.Views
{
    /// <summary>
    /// Interaction logic for MC_Window.xaml
    /// </summary>
    public partial class MC_Window : Window
    {
        CurrencyRepo repo;

        public MC_Window(CurrencyRepo r)
        {
            InitializeComponent();
            this.repo = r;
        }

        private void MC_Window_Loaded(object sender, RoutedEventArgs e)
        {
            WPF_CurrencyRepo currencyRepo = new WPF_CurrencyRepo(repo);

            this.DataContext = currencyRepo;
            CurrencyView.DataContext = currencyRepo;
        }
    }
}
