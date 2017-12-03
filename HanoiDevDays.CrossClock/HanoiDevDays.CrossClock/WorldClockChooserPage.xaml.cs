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
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            lstCities.ItemSelected += HandleCitySelected;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            lstCities.ItemSelected -= HandleCitySelected;
        }

        async void HandleCitySelected(object sender, SelectedItemChangedEventArgs e)
        {
            TimeZoneSelected?.Invoke(this, (TimeZoneDto)lstCities.SelectedItem);
            await Navigation.PopModalAsync();
        }
    }
}
