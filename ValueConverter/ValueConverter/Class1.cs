using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace ValueConverter
{
    class class1 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double miles;
            if (double.TryParse((string)value, out miles))
            {
                double kilos = miles * 1.60934;

                return kilos.ToString("f2");
            }
            else
            {
                return value;
            }
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}