﻿using System.Windows;

namespace BankingAppMVVM.Core.Commands
{
    internal class ShutDownCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}
