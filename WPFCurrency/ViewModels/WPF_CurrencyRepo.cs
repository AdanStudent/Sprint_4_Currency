using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using System.Windows.Input;

namespace WPFCurrency.ViewModels
{
    class WPF_CurrencyRepo : DependencyObject, INotifyPropertyChanged
    {
        private CurrencyRepo currencyRepo;

        public ICommand Save { get; set; }
        public ICommand MakeChange { get; set; }

        public WPF_CurrencyRepo(CurrencyRepo repo)
        {
            this.currencyRepo = repo;
            this.Save = new WPF_CurrencyRepo_SaveCommand(ExcuteCommandSave, CanExcuteCommandSave);
            this.MakeChange = new WPF_CurrencyRepo_MakeChangeCommand(ExcuteCommandChange, CanExcuteCommandChange);

            CheckRepo();
        }

        private void CheckRepo()
        {
            //when a save is loaded from other view
            //load in coins
            //change total amount displayed

        }

        public List<ICoin> Coins
        {
            get
            {
                return this.currencyRepo.Coins;
            }

            set
            {
                this.currencyRepo.Coins = value;
            }
        }

        public double TotalAmount
        {
            get;
            set;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private bool CanExcuteCommandChange(object parameter)
        {
            return true;
        }

        private void ExcuteCommandChange(object parameter)
        {
            //create change from the repo.
            ICurrencyRepo cRepo = CurrencyRepo.CreateChange(this.TotalAmount);
            this.Coins = cRepo.Coins;
            //RaisePropertyChanged that it was saved
            RaisePropertyChanged("Coins");
        }

        private bool CanExcuteCommandSave(object parameter)
        {
            return true;
        }

        private void ExcuteCommandSave(object parameter)
        {
            //write code to save the repo
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"...\RepoSaveData.txt", FileMode.Create, FileAccess.Write, FileShare.None);

            formatter.Serialize(stream, this.currencyRepo);
            stream.Close();
        }


    }

    internal class WPF_CurrencyRepo_MakeChangeCommand : ICommand
    {
        public delegate void ICommandOnExecute(object parameter);
        public delegate bool ICommandOnCanExecute(object parameter);

        private ICommandOnExecute excuteCommandChange;
        private ICommandOnCanExecute canExcuteCommandChange;

        public WPF_CurrencyRepo_MakeChangeCommand(ICommandOnExecute excuteCommandChange, ICommandOnCanExecute canExcuteCommandChange)
        {
            this.excuteCommandChange = excuteCommandChange;
            this.canExcuteCommandChange = canExcuteCommandChange;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return this.canExcuteCommandChange.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            this.excuteCommandChange.Invoke(parameter);
        }
    }

    internal class WPF_CurrencyRepo_SaveCommand : ICommand
    {
        public delegate void ICommandOnExecute (object parameter);
        public delegate bool ICommandOnCanExecute (object parameter);

        private ICommandOnExecute _execute;
        private ICommandOnCanExecute _canExecute;

        public WPF_CurrencyRepo_SaveCommand(ICommandOnExecute executeCommandSave, ICommandOnCanExecute canExcuteCommandSave)
        {
            this._execute = executeCommandSave;
            this._canExecute = canExcuteCommandSave;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return this._canExecute.Invoke(parameter);
        }

        public void Execute(object parameter)
        {
            this._execute.Invoke(parameter);
        }
    }
}
