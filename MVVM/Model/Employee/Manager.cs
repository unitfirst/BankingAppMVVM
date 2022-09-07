using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppMVVM.MVVM.Model
{
    internal class Manager : Employee
    {
        private int _userRole;

        public int UserRole
        {
            get { return _userRole; }
            set { _userRole = value; }
        }

    }
}
