using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFCurrency.ViewModels
{
    class WPF_RepoUI : WPF_CurrencyRepo
    {
        public ICommand Load { get; set; }
        public ICommand New { get; set; }


        public WPF_RepoUI(CurrencyRepo repo) : base(repo)
        {
            this.Load = new WPF_LoadCommand(ExcuteLoadCommand, CanExcuteLoadCommand);
            this.New = new WPF_NewCommand(ExcuteNewCommand, CanExcuteNewCommand);
        }

        private bool CanExcuteLoadCommand(object parameter)
        {
            return true;
        }

        private void ExcuteLoadCommand(object parameter)
        {
            //Load repo from file
        }

        private bool CanExcuteNewCommand(object parameter)
        {
            return true;
        }

        private void ExcuteNewCommand(object parameter)
        {
            this.currencyRepo = new CurrencyRepo();
        }


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
}
