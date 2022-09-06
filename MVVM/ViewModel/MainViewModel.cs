using BankingAppMVVM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BankingAppMVVM.MVVM.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        private object _currentView;
        public RelayCommand MoveWindowCommand { get; set; }
        public RelayCommand ShutDownCommand { get; set; }
        public RelayCommand MaximizeWindowCommand { get; set; }
        public RelayCommand MinimizeWindowCommand { get; set; }
        public RelayCommand ShowAccountsView { get; set; }
        public RelayCommand ShowSettingsView { get; set; }
        public RelayCommand ShowNewAccountView { get; set; }
        public RelayCommand ShowAboutView { get; set; }

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public AccountsViewModel AccountsVM { get; set; }
        public SettingsViewModel SettingsVM { get; set; }
        public NewAccountViewModel NewAccountVM { get; set; }
        public AboutViewModel AboutVM { get; set; }

        public MainViewModel()
        {
            AccountsVM = new AccountsViewModel();
            NewAccountVM = new NewAccountViewModel();
            SettingsVM = new SettingsViewModel();
            AboutVM = new AboutViewModel();

            CurrentView = AccountsVM;

            //Toolbar comands//
            MoveWindowCommand = new RelayCommand(o => { Application.Current.MainWindow.DragMove(); });
            ShutDownCommand = new RelayCommand(o => { Application.Current.Shutdown(); });
            MaximizeWindowCommand = new RelayCommand(o =>
            {
                if (Application.Current.MainWindow.WindowState == WindowState.Maximized)
                    Application.Current.MainWindow.WindowState = WindowState.Normal;
                else
                    Application.Current.MainWindow.WindowState = WindowState.Maximized;
            });
            MinimizeWindowCommand = new RelayCommand(o => { Application.Current.MainWindow.WindowState = WindowState.Minimized; });

            //Change view//
            ShowAccountsView = new RelayCommand(o => { CurrentView = AccountsVM; });
            ShowSettingsView = new RelayCommand(o => { CurrentView = SettingsVM; });
            ShowNewAccountView = new RelayCommand(o => { CurrentView = NewAccountVM; });
            ShowAboutView = new RelayCommand(o => { CurrentView = AboutVM; });
        }

    }
}
