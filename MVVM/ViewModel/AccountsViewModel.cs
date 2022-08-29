using BankingAppMVVM.Core;
using BankingAppMVVM.MVVM.View;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace BankingAppMVVM.MVVM.ViewModel
{
    internal class AccountsViewModel : ObservableObject
    {
        private RelayCommand _removeCommand;
        public ICommand UpdateCommand { get; set; }

        private AccountModel _selectedAccount;

        public ObservableCollection<AccountModel> Accounts { get; set; }

        public AccountModel SelectedAccount
        {
            get => _selectedAccount;
            set
            {
                _selectedAccount = value;
                RaisePropertyChanged();
            }
        }

        public RelayCommand RemoveCommand
        {
            get
            {
                return _removeCommand ??
                    (_removeCommand = new RelayCommand(obj =>
                    {
                        if (obj is AccountModel account)
                        {
                            Accounts.Remove(account);
                        }
                    },
                    (obj) => Accounts.Count > 0));
            }
        }

        public AccountsViewModel()
        {
            Accounts = new ObservableCollection<AccountModel>
            {
                new AccountModel() { Id = 1, FirstName = "Alex", LastName = "Monty", PhoneNumber = "+79990003938", Passport = 0099882234 },
                new AccountModel() { Id = 9, FirstName = "Hideo", LastName = "Kodzima", PhoneNumber = "+79991223323", Passport = 0000191123 },
                new AccountModel() { Id = 10, FirstName = "Snake", LastName = "Liquid", PhoneNumber = "+79995555955", Passport = 222033223 },
                new AccountModel() { Id = 11, FirstName = "Snake", LastName = "Solid", PhoneNumber = "+7996444353", Passport = 445393921 }
            };
        }
    }
}
