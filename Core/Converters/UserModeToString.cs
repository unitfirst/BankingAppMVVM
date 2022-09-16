using System;
using System.Globalization;
using System.Windows.Data;
using BankingAppMVVM.MVVM.Model.Employees;
using BankingAppMVVM.MVVM.Model.Employees.Base;

namespace BankingAppMVVM.Core.Converters
{
    public class UserModeToString : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not Employee employee) return null;
            return employee switch
            {
                Consultant _ => "Consultant",
                Manager _ => "Manager",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}