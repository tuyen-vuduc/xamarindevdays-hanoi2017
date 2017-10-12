using Xamarin.Forms;
using HanoiDevDays.CrossClock.DTOs;
using System.Linq;
using System;

namespace HanoiDevDays.CrossClock
{
    public partial class WorldClockChooserPage : ContentPage
    {
        public event EventHandler<TimeZoneDto> TimeZoneSelected;

        public WorldClockChooserPage()
        {
            InitializeComponent();

            BindingContext = new WorldClockChooserPageViewModel(Navigation);

            lstCities.ItemSelected += async delegate
            {
                TimeZoneSelected?.Invoke(this, (TimeZoneDto)lstCities.SelectedItem);
                await Navigation.PopAsync();
            };
        }
    }
}
