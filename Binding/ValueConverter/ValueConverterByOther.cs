using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace ValueConverter
{
    public class ValueConverterByOther : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double height = (double)value;
            if (double.TryParse(parameter.ToString(), out double d))
            {
                return height * d;
            }
            else
            {
                throw new Exception($"parameter converter error: {parameter} .");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
