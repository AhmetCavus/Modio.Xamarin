﻿using System;
using System.Globalization;
using Xamarin.Forms;

namespace Modio.Xamarin.UI.Converters
{
    public class AmbientLightValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is double))
            {
                throw new InvalidOperationException("The target must be a double");
            }

            var lightValue = (double)value;

            return $"{lightValue.ToString("N0")}K";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
