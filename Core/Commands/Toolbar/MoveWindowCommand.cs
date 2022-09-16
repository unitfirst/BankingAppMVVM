using System.Windows;
using BankingAppMVVM.Core.Commands.Base;

namespace BankingAppMVVM.Core.Commands.Toolbar
{
    public class MoveWindowCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        //public override void Execute(object parameter) => Application.Current.MainWindow.DragMove();
        public override void Execute(object parameter)
        {
            foreach (var item in Application.Current.Windows)
            {
                (item as Window).DragMove();
            }
        }
    }
}
