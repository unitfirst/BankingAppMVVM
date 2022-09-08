using BankingAppMVVM.MVVM.Model.Accounts;
using BankingAppMVVM.MVVM.Model.Employees.Base;

namespace BankingAppMVVM.MVVM.Model.Employees
{
    public class Consultant : Employee
    {
        public override AccountInfo GetAccountInfo(Account client)
        {
            throw new System.NotImplementedException();
        }
    }
}
