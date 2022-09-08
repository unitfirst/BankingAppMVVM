using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BankingAppMVVM.MVVM.Model.Account.Base
{
    public class Person: INotifyPropertyChanged
    {
        #region Fields

        private string _firstName;
        private string _lastName;

        #endregion

        #region Props

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

        #endregion

        #region Declare

        public Person() { }
        public Person(string firstName, string lastName)
        {
            FirstName = _firstName;
            LastName = _lastName;
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
