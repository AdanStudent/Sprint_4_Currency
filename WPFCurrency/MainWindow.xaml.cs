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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFCurrency.ViewModels;
using WPFCurrency.Views;

namespace WPFCurrency
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        CurrencyRepo repo = new CurrencyRepo();

        public MainWindow()
        {
            InitializeComponent();
            //currencyRepo

        }

        private void RepoUI_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RepoUI repoUI = new RepoUI(repo);
        }

        //private void MakeChange_Loaded(object sender, RoutedEventArgs e)
        //{
        //    WPF_CurrencyRepo currencyRepo = new WPF_CurrencyRepo(repo);

        //    this.DataContext = currencyRepo;
        //    MakeChange.DataContext = currencyRepo;
        //}
    }
}
