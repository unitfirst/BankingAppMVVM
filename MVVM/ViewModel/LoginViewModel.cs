using BankingAppMVVM.Core.Commands;
using BankingAppMVVM.MVVM.Model.Employees;
using BankingAppMVVM.MVVM.Model.Employees.Base;
using BankingAppMVVM.ViewModel.Base;
using System.Windows;
using System.Windows.Input;

namespace BankingAppMVVM.MVVM.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        #region Commands

        #region LoginAsConsultantCommand

        public ICommand LoginAsConsultantCommand { get; }
        private void OnLoginAsConsultantCommandExecuted(object p) { OpenMainWindow(new Consultant(), p); }
        private bool CanLoginAsConsultantCommandExecute(object p) => true;

        #endregion

        #region LoginAsManagerCommand

        public ICommand LoginAsManagerCommand { get; }
        private void OnLoginAsManagerCommandExecuted(object p) { OpenMainWindow(new Manager(), p); }
        private bool CanLoginAsManagerCommandExecute(object p) => true;

        #endregion

        private void OpenMainWindow(Employee employee, object p)
        {
            CloseThisWindow(p);

            MainWindow mainWindow = new MainWindow { DataContext = new MainViewModel(employee) };
            mainWindow.Show();
        }

        private void CloseThisWindow(object p)
        {
            if (p is Window window) window.Close();
        }
        #endregion

        public LoginViewModel()
        {
            LoginAsConsultantCommand = new RelayCommand(OnLoginAsConsultantCommandExecuted, CanLoginAsConsultantCommandExecute);
            LoginAsManagerCommand = new RelayCommand(OnLoginAsManagerCommandExecuted, CanLoginAsManagerCommandExecute);
        }
    }
}
