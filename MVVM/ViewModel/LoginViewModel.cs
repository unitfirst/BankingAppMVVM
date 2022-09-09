using BankingAppMVVM.ViewModel.Base;

namespace BankingAppMVVM.MVVM.ViewModel
{
    internal class LoginViewModel : ViewModelBase
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
        public LoginViewModel()
        {
        }
    }
}
