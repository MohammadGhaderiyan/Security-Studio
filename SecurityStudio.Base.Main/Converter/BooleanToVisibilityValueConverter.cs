using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SecurityStudio.Base.Main.Converter
{
    public class BooleanToVisibilityValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || value is bool)
            {
                var realValue = (bool?)value;
                switch (realValue)
                {
                    case true:
                        return Visibility.Visible;
                    case false:
                    case null:
                        return Visibility.Collapsed;
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}