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
    /// Interaction logic for RUI_Window.xaml
    /// </summary>
    public partial class RUI_Window : Window
    {
        CurrencyRepo repo;
        public RUI_Window(CurrencyRepo r)
        {
            this.repo = r;
            InitializeComponent();
        }

        private void RUI_Window_Loaded(object sender, RoutedEventArgs e)
        {
            WPF_RepoUI wPF_RepoUI = new WPF_RepoUI(this.repo);

            this.DataContext = wPF_RepoUI;
            CurrencyView.DataContext = wPF_RepoUI;
        }
    }
}
