using System.Windows;
using BankingAppMVVM.MVVM.View.LoginWindow;
using BankingAppMVVM.MVVM.ViewModel;

namespace BankingAppMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
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