using BankingAppMVVM.MVVM.ViewModel;
using System.Windows.Controls;

namespace BankingAppMVVM.MVVM.View
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
