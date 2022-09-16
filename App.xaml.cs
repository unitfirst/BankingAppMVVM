using BankingAppMVVM.MVVM.View.LoginWindow;
using BankingAppMVVM.MVVM.ViewModel;
using System.Windows;

namespace BankingAppMVVM
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            new LoginWindow { DataContext = new LoginViewModel() }.Show();
        }
    }
}
