using System.Windows;
using BankingAppMVVM.Core.Commands.Base;

namespace BankingAppMVVM.Core.Commands
{
    public class ShutDownCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}