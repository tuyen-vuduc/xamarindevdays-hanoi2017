using System;
using System.Globalization;
using Xamarin.Forms;
namespace HanoiDevDays.CrossClock.Converters
{
    public class ZoneDiffValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime zoneTime) {
                var diff = zoneTime - DateTime.Now;

                return string.Format("Today, {0:+#;-#;0}HRS", diff.Hours);
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
