using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAppMVVM.MVVM.ViewModel
{
    internal class GlobalViewModel
    {
        public static GlobalViewModel Global { get; } = new GlobalViewModel();

        private string _access;

        public string Access
        {
            get { return _access; }
            set { _access = value; }
        }

    }
}
