using BankingAppMVVM.MVVM.Model.Account;
using BankingAppMVVM.MVVM.Model.Account.Base;
using System;

namespace BankingAppMVVM.MVVM.View
{
    public class Account : Person
    {
        #region fields

        private static int staticId;
        private string _phoneNumber;
        private int _passport;

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
            staticId = 0;
        }

        public Account() { }

        public Account(PhoneNumber phoneNumber, Passport passport, string firstName, string lastName)
            : base(firstName, lastName)
        {
            PhoneNumber = phoneNumber;
            Passport = passport;
        }

        #endregion
    }
}