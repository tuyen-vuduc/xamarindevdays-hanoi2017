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

            lstCities.ItemsSource = TimeZoneData.GetTimeZones();
            txtQuery.SearchButtonPressed += delegate
            {
                var query = txtQuery.Text?.ToUpper() ?? string.Empty;
                lstCities.ItemsSource = TimeZoneData
                    .GetTimeZones()
                    .Where(x => x.ZoneName.ToUpper().Contains(query))
                    .ToList();
            };

            lstCities.ItemSelected += async delegate
            {
                TimeZoneSelected?.Invoke(this, (TimeZoneDto) lstCities.SelectedItem);
                await Navigation.PopAsync();
            };
        }
    }
}
