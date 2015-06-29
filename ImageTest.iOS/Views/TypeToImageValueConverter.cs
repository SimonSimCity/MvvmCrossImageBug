using System;
using Cirrious.CrossCore.Converters;
using System.Globalization;
using ImageTest.Core;

namespace ImageTest.iOS
{
    public class TypeToImageValueConverter : IMvxValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "res:icon_type_" + (string)value + ".png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

