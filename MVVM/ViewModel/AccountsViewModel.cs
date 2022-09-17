﻿using BankingAppMVVM.Core;
using BankingAppMVVM.Core.Commands;
using BankingAppMVVM.MVVM.Model.Accounts;
using BankingAppMVVM.MVVM.Model.Accounts.ProtectedData;
using System.Collections.ObjectModel;
using System.Windows.Input;
using BankingAppMVVM.Core.Commands.Base;
using BankingAppMVVM.MVVM.ViewModel.Base;

namespace BankingAppMVVM.MVVM.ViewModel
{
    public class AccountsViewModel : ViewModelBase
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

        public Command RemoveCommand
        {
            get
            {
                return _removeCommand ??
                    (_removeCommand = new RelayCommand(obj =>
                    {
                        if (obj is Account account)
                        {
                            Accounts.Remove(account);
                        }
                    },
                    (obj) => Accounts.Count > 0));
            }
        }
        public Command ApplyCommand
        {
            get
            {
                return _applyCommand ??
                    (_applyCommand = new RelayCommand(obj =>
                    {
                        if (obj is Account account)
                        {
                            Account tempAccount = SelectedAccount;
                            int index = Accounts.IndexOf(SelectedAccount);

                            Accounts.Remove(SelectedAccount);
                            Accounts.Insert(index, tempAccount);
                            SelectedAccount = tempAccount;
                        }
                    },
                    (obj) => Accounts.Count > 0));
            }
        }

        public AccountsViewModel()
        {
            Accounts = new ObservableCollection<Account>
            {
                new Account() { FirstName = "Hideo", LastName = "Kodzima", PhoneNumber = new PhoneNumber("+791012345"), Passport = new Passport(00998772234) },
            };
        }
    }
}
