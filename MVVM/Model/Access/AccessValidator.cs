using BankingAppMVVM.MVVM.Model.Access.Parameters;

namespace BankingAppMVVM.MVVM.Model.Access
{
    public class AccessValidator
    {
        public CommandAccess CommandAccess;
        public EditAccess EditAccess;

        public AccessValidator(CommandAccess commands, EditAccess editFields)
        {
            CommandAccess = commands;
            EditAccess = editFields;
        }
    }
}