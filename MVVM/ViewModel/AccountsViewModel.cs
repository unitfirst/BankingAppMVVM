using BankingAppMVVM.Core;
using BankingAppMVVM.MVVM.View;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace BankingAppMVVM.MVVM.ViewModel
{
    internal class AccountsViewModel : ViewModelBase
    {
        private Command _applyCommand;
        private Command _removeCommand;
        private Command _addCommand;
        private Account _selectedAccount;
        public ICommand UpdateCommand { get; set; }

        public ObservableCollection<Account> Accounts { get; set; }

        public Account SelectedAccount
        {
            get => _selectedAccount;
            set
            {
                _selectedAccount = value;
                OnPropertyChanged();
            }
        }

        //public Command RemoveCommand
        //{
        //    get
        //    {
        //        return _removeCommand ??
        //            (_removeCommand = new Command(obj =>
        //            {
        //                if (obj is Account account)
        //                {
        //                    Accounts.Remove(account);
        //                }
        //            },
        //            (obj) => Accounts.Count > 0));
        //    }
        //}
        //public Command ApplyCommand
        //{
        //    get
        //    {
        //        return _applyCommand ??
        //            (_applyCommand = new Command(obj =>
        //            {
        //                if (obj is Account account)
        //                {
        //                    Account tempAccount = SelectedAccount;
        //                    int index = Accounts.IndexOf(SelectedAccount);

        //                    Accounts.Remove(SelectedAccount);
        //                    Accounts.Insert(index, tempAccount);
        //                    SelectedAccount = tempAccount;
        //                }
        //            },
        //            (obj) => Accounts.Count > 0));
        //    }
        //}

        public AccountsViewModel()
        {
            Accounts = new ObservableCollection<Account>
            {
                new Account() { FirstName = "Alex", LastName = "Monty", PhoneNumber = "+79990003938", Passport = 00998772234 },
            };
        }
    }
}
