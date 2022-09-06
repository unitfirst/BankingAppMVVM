using BankingAppMVVM.Core;

namespace BankingAppMVVM.MVVM.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        #region Command fields
        public Command ShowAccountsView { get; set; }
        public Command ShowSettingsView { get; set; }
        public Command ShowNewAccountView { get; set; }
        public Command ShowAboutView { get; set; }

        #endregion

        #region View fields

        public AccountsViewModel AccountsVM { get; set; }
        public SettingsViewModel SettingsVM { get; set; }
        public NewAccountViewModel NewAccountVM { get; set; }
        public AboutViewModel AboutVM { get; set; }

        #endregion

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

        public MainViewModel()
        {
            #region Views

            AccountsVM = new AccountsViewModel();
            NewAccountVM = new NewAccountViewModel();
            SettingsVM = new SettingsViewModel();
            AboutVM = new AboutViewModel();

            CurrentView = AccountsVM;

            #endregion

            #region Toolbar comands


            #endregion

            #region Change view

            //ShowAccountsView = new Command(o => { CurrentView = AccountsVM; });
            //ShowSettingsView = new Command(o => { CurrentView = SettingsVM; });
            //ShowNewAccountView = new Command(o => { CurrentView = NewAccountVM; });
            //ShowAboutView = new Command(o => { CurrentView = AboutVM; });

            #endregion
        }

    }
}
