using System;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace HanoiDevDays.CrossClock.Converters
{
    public class CityFromZoneValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string zoneName)
            {
                return zoneName.Split('/').Last();
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
