﻿using BankingAppMVVM.MVVM.Model.Access;
using BankingAppMVVM.MVVM.Model.Accounts;

namespace BankingAppMVVM.MVVM.Model.Employees.Base
{
    public abstract class Employee
    {
        public AccessValidator DataAccess { get; protected set; }

        public abstract AccountInfo GetAccountInfo(Account client);
    }
}