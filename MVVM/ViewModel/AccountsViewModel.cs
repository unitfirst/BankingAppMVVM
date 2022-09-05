﻿using BankingAppMVVM.Core;
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
        private RelayCommand _applyCommand;
        private RelayCommand _removeCommand;
        private RelayCommand _addCommand;
        private Account _selectedAccount;
        public ICommand UpdateCommand { get; set; }

        public ObservableCollection<Account> Accounts { get; set; }
        public GlobalViewModel Access { get; } = GlobalViewModel.Global;

        public Account SelectedAccount
        {
            get => _selectedAccount;
            set
            {
                _selectedAccount = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand RemoveCommand
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
        public RelayCommand ApplyCommand
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
                new Account() { Id = 1, FirstName = "Alex", LastName = "Monty", PhoneNumber = "+79990003938", Passport = 0099882234 },
                new Account() { Id = 2, FirstName = "Hideo", LastName = "Kodzima", PhoneNumber = "+79991223323", Passport = 0000191123 },
                new Account() { Id = 3, FirstName = "Snake", LastName = "Liquid", PhoneNumber = "+79995555955", Passport = 222033223 },
                new Account() { Id = 4, FirstName = "Snake", LastName = "Solid", PhoneNumber = "+7996444353", Passport = 445393921 },
                new Account() { Id = 5, FirstName = "Dart", LastName = "Vader", PhoneNumber = "+79990003938", Passport = 0099882234 },
                new Account() { Id = 6, FirstName = "Capitan", LastName = "America", PhoneNumber = "+79991223323", Passport = 0000191123 },
                new Account() { Id = 7, FirstName = "Foxtrot", LastName = "James", PhoneNumber = "+79995555955", Passport = 222033223 },
                new Account() { Id = 8, FirstName = "Jimmy", LastName = "AndBilly", PhoneNumber = "+7996444353", Passport = 445393921 },
                new Account() { Id = 9, FirstName = "Froggy", LastName = "Monty", PhoneNumber = "+7956468456", Passport = 0099882234 },
                new Account() { Id = 10, FirstName = "Lucky", LastName = "Strike", PhoneNumber = "+794325543253", Passport = 0000191123 },
                new Account() { Id = 11, FirstName = "Taylor", LastName = "Swift", PhoneNumber = "+79768678678", Passport = 222033223 },
                new Account() { Id = 12, FirstName = "Marilyn", LastName = "Manson", PhoneNumber = "+795436435", Passport = 445393921 },
                new Account() { Id = 13, FirstName = "Jared", LastName = "Leto", PhoneNumber = "+79934563456", Passport = 0099882234 },
                new Account() { Id = 14, FirstName = "DiCaprio", LastName = "Leonardo", PhoneNumber = "+7121112313", Passport = 0000191123 },
                new Account() { Id = 15, FirstName = "Solo", LastName = "Han", PhoneNumber = "+777676767675", Passport = 222033223 },
                new Account() { Id = 16, FirstName = "Uniform", LastName = "Blabla", PhoneNumber = "+700009870", Passport = 445393921 },
                new Account() { Id = 17, FirstName = "Lolly", LastName = "Bomb", PhoneNumber = "+235435232345", Passport = 222033223 },
                new Account() { Id = 18, FirstName = "Michael", LastName = "Bay", PhoneNumber = "+76789433245", Passport = 445393921 },
                new Account() { Id = 19, FirstName = "Alla", LastName = "Pugacheva", PhoneNumber = "+834937243253245", Passport = 0099882234 },
                new Account() { Id = 20, FirstName = "Mix", LastName = "Tape", PhoneNumber = "+56765784566", Passport = 0000191123 },
                new Account() { Id = 21, FirstName = "Name", LastName = "Namename", PhoneNumber = "+213424356748", Passport = 222033223 },
                new Account() { Id = 22, FirstName = "Bad", LastName = "Trip", PhoneNumber = "+01092929290", Passport = 445393921 }
            };
        }
    }
}
