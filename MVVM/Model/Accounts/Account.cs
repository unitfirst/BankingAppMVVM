using BankingAppMVVM.MVVM.Model.Accounts.Base;
using BankingAppMVVM.MVVM.Model.Accounts.ProtectedData;
using System;

namespace BankingAppMVVM.MVVM.Model.Accounts
{
    public class Account : Person
    {
        #region fields

        private static int staticId;
        private static int nextId()
        {
            return staticId++;
        }

        #endregion

        #region Props

        public int Id { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Passport Passport { get; set; }
        public DateTime AddTime { get; set; } = DateTime.Now;
        public DateTime LastUpdated { get; set; } = DateTime.Now;

        #endregion

        #region Declare
        static Account()
        {
            staticId = 1;
        }

        public Account() { }

        public Account(string firstName, string lastName, PhoneNumber phoneNumber, Passport passport)
            : base(firstName, lastName)
        {
            PhoneNumber = phoneNumber;
            Passport = passport;
        }

        #endregion
    }
}