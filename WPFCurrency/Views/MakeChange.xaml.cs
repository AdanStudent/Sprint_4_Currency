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

namespace WPFCurrency.Views
{
    /// <summary>
    /// Interaction logic for MakeChange.xaml
    /// </summary>
    public partial class MakeChange : UserControl
    {
        CurrencyRepo repo;

        public MakeChange()
        {
            InitializeComponent();
        }
        public MakeChange(CurrencyRepo r)
        {
            this.repo = r;
            InitializeComponent();
        }

    }
}
