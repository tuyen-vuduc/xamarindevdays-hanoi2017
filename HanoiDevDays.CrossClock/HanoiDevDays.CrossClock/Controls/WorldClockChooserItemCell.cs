using System;

using Xamarin.Forms;
using System.Linq;
using System.Globalization;

namespace HanoiDevDays.CrossClock.Controls
{
    public class WorldClockChooserItemCell : ViewCell
    {
        Label lblCity;
        Label lblCountry;

        public WorldClockChooserItemCell()
        {
            lblCity = new Label
            {
                TextColor = (Color)App.Current.Resources["ColorTextPrimary"],
                VerticalTextAlignment = TextAlignment.Center
            };
            lblCountry = new Label
            {
                TextColor = (Color)App.Current.Resources["ColorTextPrimary"],
                VerticalTextAlignment = TextAlignment.Center
            };

            var container = new Grid
            {
                BackgroundColor = (Color)App.Current.Resources["ColorPrimary"],
            };
            var stack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Spacing = 0,
                Margin = new Thickness(16, 0)
            };
            stack.Children.Add(lblCity);
            stack.Children.Add(new Label
            {
                TextColor = (Color)App.Current.Resources["ColorTextPrimary"],
                VerticalTextAlignment = TextAlignment.Center,
                Text = ", "
            });
            stack.Children.Add(lblCountry);

            container.Children.Add(stack);
            container.Children.Add(new BoxView
            {
                VerticalOptions = LayoutOptions.End,
                BackgroundColor = (Color)App.Current.Resources["ColorSeparatorPrimary"],
                HeightRequest = 1
            });

            lblCity.SetBinding(Label.TextProperty, "ZoneName", converter: new CityFromZoneValueConverter());
            lblCountry.SetBinding(Label.TextProperty, "CountryName");

            View = container;
        }
    }

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

