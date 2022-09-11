using BankingAppMVVM.MVVM.Model.Accounts;
using BankingAppMVVM.MVVM.Model.Employees.Base;

namespace BankingAppMVVM.MVVM.Model.Employees
{
    internal class Manager : Employee
    {
        public override AccountInfo GetAccountInfo(Account client)
        {
            throw new System.NotImplementedException();
        }
    }
}
