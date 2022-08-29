using BankingAppMVVM.Core;
using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BankingAppMVVM.MVVM.View
{
    public class AccountModel : INotifyPropertyChanged
    {
        private readonly int _id;
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private int _passport;
        
        public DateTime AddTime { get; set; }
        public DateTime LastUpdated { get; set; }
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
                OnPropertyChanged(Passport.ToString());
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}