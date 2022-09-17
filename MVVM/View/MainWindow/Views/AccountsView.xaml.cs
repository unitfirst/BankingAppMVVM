using System.Windows.Controls;
using BankingAppMVVM.MVVM.ViewModel;

namespace BankingAppMVVM.MVVM.View.MainWindow.Views
{
    /// <summary>
    /// Логика взаимодействия для AccountsView.xaml
    /// </summary>
    public partial class AccountsView : UserControl
    {
        public AccountsView()
        {
            InitializeComponent();
            DataContext = new AccountsViewModel();
        }
    }
}