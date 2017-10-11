using System;

using Xamarin.Forms;
using HanoiDevDays.CrossClock.DTOs;
using System.Linq;

namespace HanoiDevDays.CrossClock.Controls
{
    public class WorldClockChooserItemCell : ViewCell
    {
        Label lblCity;
        
        public WorldClockChooserItemCell()
        {
            lblCity = new Label
            {
                TextColor = (Color)App.Current.Resources["ColorTextPrimary"],
                VerticalTextAlignment = TextAlignment.Center,
                Margin = new Thickness(16, 0)
            };

            var container = new Grid {
                BackgroundColor = (Color)App.Current.Resources["ColorPrimary"],
            };

            container.Children.Add(lblCity);
            container.Children.Add(new BoxView {
                VerticalOptions = LayoutOptions.End,
                BackgroundColor = (Color)App.Current.Resources["ColorSeparatorPrimary"],
                HeightRequest= 1
            });

            View = container;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var data = (TimeZoneDto)BindingContext;

            lblCity.Text = $"{data.ZoneName.Split('/')[1]}, {data.CountryName}";
        }
    }
}

