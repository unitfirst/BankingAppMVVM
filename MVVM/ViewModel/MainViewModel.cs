using BankingAppMVVM.Core.Commands;
using BankingAppMVVM.MVVM.Model.Accounts;
using BankingAppMVVM.MVVM.Model.Employees.Base;
using BankingAppMVVM.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BankingAppMVVM.MVVM.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region Current View

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region View fields

        public AccountsViewModel AccountsVM { get; set; }
        public SettingsViewModel SettingsVM { get; set; }
        public NewAccountViewModel NewAccountVM { get; set; }
        public AboutViewModel AboutVM { get; set; }
        public Account Account { get; set; }

        #endregion

        #region Commands

        #region ShowAccountsView

        public ICommand ShowAccountsView { get; }
        private bool CanShowAccountsViewExecute(object p) => true;
        private void OnShowAccountsViewExecuted(object p)
        {
            CurrentView = AccountsVM;
        }

        #endregion

        #region ShowSettingsView

        public ICommand ShowSettingsView { get; }
        private bool CanShowSettingsViewExecute(object p) => true;
        private void OnShowSettingsViewExecuted(object p)
        {
            CurrentView = SettingsVM;
        }

        #endregion

        #region ShowSettingsView

        public ICommand ShowNewAccountView { get; }
        private bool CanShowNewAccountViewExecute(object p) => true;
        private void OnShowNewAccountViewExecuted(object p)
        {
            CurrentView = NewAccountVM;
        }

        #endregion

        #region ShowAboutView

        public ICommand ShowAboutView { get; }
        private bool CanShowAboutViewExecute(object p) => true;
        private void OnShowAboutViewExecuted(object p)
        {
            CurrentView = AboutVM;
        }

        #endregion

        #endregion


        public MainViewModel()
        {
            #region Views

            AccountsVM = new AccountsViewModel();
            NewAccountVM = new NewAccountViewModel();
            SettingsVM = new SettingsViewModel();
            AboutVM = new AboutViewModel();

            CurrentView = AccountsVM;

            #endregion

            #region Change view commands

            ShowAccountsView = new RelayCommand(OnShowAccountsViewExecuted, CanShowAccountsViewExecute);
            ShowSettingsView = new RelayCommand(OnShowSettingsViewExecuted, CanShowSettingsViewExecute);
            ShowNewAccountView = new RelayCommand(OnShowNewAccountViewExecuted, CanShowNewAccountViewExecute);
            ShowAboutView = new RelayCommand(OnShowAboutViewExecuted, CanShowAboutViewExecute);

            #endregion
        }
    }
}
