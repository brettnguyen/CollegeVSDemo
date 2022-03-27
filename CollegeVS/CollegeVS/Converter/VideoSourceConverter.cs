using System;
using System.Globalization;
using Xamarin.Forms;

namespace CollegeVS.Converter
{
    public class VideoSourceConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            if (string.IsNullOrWhiteSpace(value.ToString()))
                return null;

            if (Device.RuntimePlatform == Device.UWP)
                return new Uri($"ms-appx:///Assets/{value}");
            else
                return new Uri($"ms-appx:///{value}");
        }
    }
}
