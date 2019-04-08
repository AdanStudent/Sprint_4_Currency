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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RUI_Window repoUI = new RUI_Window(this.repo);
            repoUI.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MC_Window mC_Window = new MC_Window(this.repo);
            mC_Window.Show();
        }
    }
}
