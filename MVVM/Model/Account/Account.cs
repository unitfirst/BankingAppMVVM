using BankingAppMVVM.Core;
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BankingAppMVVM.MVVM.View
{
    public class Account : INotifyPropertyChanged
    {
        #region fields

        private static int staticId;
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private int _passport;


        #endregion

        #region Properties

        private static int nextId()
        {
            return staticId++;
        }
        public DateTime AddTime { get; set; } = DateTime.Now;
        public DateTime LastUpdated { get; set; } = DateTime.Now;
        public int Id { get; set; }
        public string FirstName
        {
            get => _firstName;
            set
            {
                if (_firstName == value) return;

                _firstName = value;
                OnPropertyChanged(FirstName);
            }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                if (_lastName == value) return;

                _lastName = value;
                OnPropertyChanged(LastName);
            }
        }
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if (_phoneNumber == value) return;

                _phoneNumber = value;
                OnPropertyChanged(PhoneNumber);
            }
        }
        public int Passport
        {
            get => _passport;
            set
            {
                if (_passport == value) return;

                _passport = value;
                OnPropertyChanged(Passport);
            }
        }

        #endregion

        #region Declare
        static Account()
        {
            staticId = 0;
        }

        public Account(DateTime addTime, DateTime lastUpdated, int id, string firstName, string secondName, string lastName, string phoneNumber, int passport, bool isNew)
        {
            AddTime = addTime;
            LastUpdated = lastUpdated;
            Id = Account.nextId();
            FirstName = firstName;
            LastName = secondName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Passport = passport;
        }

        #endregion

        #region OnPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}