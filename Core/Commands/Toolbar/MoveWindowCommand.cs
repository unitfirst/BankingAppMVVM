using System.Windows;

namespace BankingAppMVVM.Core.Commands
{
    public class MoveWindowCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.MainWindow.DragMove();
    }
}
