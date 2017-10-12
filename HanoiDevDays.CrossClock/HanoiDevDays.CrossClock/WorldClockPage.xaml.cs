using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HanoiDevDays.CrossClock.Models;
using HanoiDevDays.CrossClock.DTOs;
using System.Linq;

namespace HanoiDevDays.CrossClock
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorldClockPage : ContentPage
    {
        List<WorldClockItemModel> worldClockItems;
        Random random;

        public WorldClockPage()
        {
            InitializeComponent();
            worldClockItems = new List<WorldClockItemModel>(12);
            lstClocks.ItemSelected += delegate
            {
                lstClocks.SelectedItem = null;
            };
            btnAdd.Clicked += HandleAddButtonClicked;

            random = new Random();
        }

        async void HandleAddButtonClicked(object sender, EventArgs e)
        {
            //worldClockItems.Add(new WorldClockItemModel
            //{
            //    City = "Hanoi",
            //    TimeZone = random.Next(10000, 100000),
            //    CurrentTime = DateTime.Now.AddHours(random.Next(0, 12))
            //});

            var chooserPage = new WorldClockChooserPage();
            chooserPage.TimeZoneSelected += HandleTimeZomeSelected;
            await Navigation.PushAsync(chooserPage);
        }

        public void HandleDeleteButtonClicked(object sender, WorldClockItemModel item)
        {
            worldClockItems.Remove(item);

            ReloadData();
        }

        void HandleTimeZomeSelected(object sender, TimeZoneDto timeZone)
        {
            var timeZoneAdded = worldClockItems.Any(x => timeZone.ZoneName.EndsWith($"/{x.City}", StringComparison.OrdinalIgnoreCase));
            if (timeZoneAdded)
            {
                return;
            }

            worldClockItems.Add(new WorldClockItemModel
            {
                GmtOffset = timeZone.GmtOffset,
                City = timeZone.ZoneName.Split('/').Last()
            });

            ReloadData();
        }

        void ReloadData()
        {
            lstClocks.ItemsSource = new List<WorldClockItemModel>(worldClockItems);
        }
    }
}