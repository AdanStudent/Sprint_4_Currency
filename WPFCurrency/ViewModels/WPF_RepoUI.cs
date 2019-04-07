using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFCurrency.ViewModels
{
    class WPF_RepoUI : WPF_CurrencyRepo
    {
        public ICommand Load { get; set; }
        public ICommand New { get; set; }
        public ICommand Add { get; set; }

        public ObservableCollection<ICoin> USCoins
        {
            get;
            set;
        }
        public ICoin SelectedCoin
        {
            get;
            set;
        }

        public int AmountToAdd
        {
            get;
            set;
        }

        public WPF_RepoUI(CurrencyRepo repo) : base(repo)
        {
            this.Load = new WPF_LoadCommand(ExcuteLoadCommand, CanExcuteLoadCommand);
            this.New = new WPF_NewCommand(ExcuteNewCommand, CanExcuteNewCommand);
            this.Add = new WPF_AddCommand(ExcuteAddCommand, CanExcuteAddCommand);

            CreateObservableList();

            AmountToAdd = 1;
        }

        private void CreateObservableList()
        {
            this.USCoins = new ObservableCollection<ICoin>();

            this.USCoins.Add(new Penny());
            this.USCoins.Add(new Nickel());
            this.USCoins.Add(new Dime());
            this.USCoins.Add(new Quarter());
            this.USCoins.Add(new HalfDollar());
            this.USCoins.Add(new DollarCoin());

            this.SelectedCoin = this.USCoins[0];
        }

        #region Commands
        private bool CanExcuteLoadCommand(object parameter)
        {
            return true;
        }

        private void ExcuteLoadCommand(object parameter)
        {
            //Load repo from file
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"...\RepoSaveData.txt", FileMode.Open, FileAccess.Read, FileShare.None);
            CurrencyRepo temp = (CurrencyRepo)formatter.Deserialize(stream);
            stream.Close();

            this.currencyRepo = temp;
            RaisePropertyChanged("TotalAmount");
        }

        private bool CanExcuteNewCommand(object parameter)
        {
            return true;
        }

        private void ExcuteNewCommand(object parameter)
        {
            this.currencyRepo = new CurrencyRepo();
            RaisePropertyChanged("TotalAmount");
        }

        private bool CanExcuteAddCommand(object parameter)
        {
            return true;
        }

        private void ExcuteAddCommand(object parameter)
        {
            for (int i = 0; i < AmountToAdd; i++)
            {
                this.currencyRepo.AddCoin(this.SelectedCoin);
            }

            this.AmountToAdd = 1;
            RaisePropertyChanged("TotalAmount");
        }
    #endregion

    }

    internal class WPF_LoadCommand : ICommand
    {
        public delegate void ICommandOnExecute(object parameter);
        public delegate bool ICommandOnCanExecute(object parameter);

        private ICommandOnExecute excuteLoadCommand;
        private ICommandOnCanExecute canExcuteLoadCommand;

        public WPF_LoadCommand(ICommandOnExecute excuteLoadCommand, ICommandOnCanExecute canExcuteLoadCommand)
        {
            this.excuteLoadCommand = excuteLoadCommand;
            this.canExcuteLoadCommand = canExcuteLoadCommand;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return this.canExcuteLoadCommand.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            this.excuteLoadCommand.Invoke(parameter);
        }
    }

    internal class WPF_NewCommand : ICommand
    {
        public delegate void ICommandOnExecute(object parameter);
        public delegate bool ICommandOnCanExecute(object parameter);

        private ICommandOnExecute excuteNewCommand;
        private ICommandOnCanExecute canExcuteNewCommand;

        public WPF_NewCommand(ICommandOnExecute excuteNewCommand, ICommandOnCanExecute canExcuteNewCommand)
        {
            this.excuteNewCommand = excuteNewCommand;
            this.canExcuteNewCommand = canExcuteNewCommand;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return this.canExcuteNewCommand.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            this.excuteNewCommand.Invoke(parameter);
        }
    }
    internal class WPF_AddCommand : ICommand
    {
        public delegate void ICommandOnExecute(object parameter);
        public delegate bool ICommandOnCanExecute(object parameter);

        private ICommandOnExecute excuteNewCommand;
        private ICommandOnCanExecute canExcuteNewCommand;

        public WPF_AddCommand(ICommandOnExecute excuteNewCommand, ICommandOnCanExecute canExcuteNewCommand)
        {
            this.excuteNewCommand = excuteNewCommand;
            this.canExcuteNewCommand = canExcuteNewCommand;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return this.canExcuteNewCommand.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            this.excuteNewCommand.Invoke(parameter);
        }
    }
}
