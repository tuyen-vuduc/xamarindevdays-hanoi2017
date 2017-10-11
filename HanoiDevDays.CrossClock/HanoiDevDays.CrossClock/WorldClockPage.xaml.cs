using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HanoiDevDays.CrossClock.Models;

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
            lstClocks.ItemsSource = worldClockItems;
            btnAdd.Clicked += HandleAddButtonClicked;

            random = new Random();
        }

        void HandleAddButtonClicked(object sender, EventArgs e)
        {
            worldClockItems.Add(new WorldClockItemModel
            {
                City = "Hanoi",
                TimeZone = random.Next(10000, 100000),
                CurrentTime = DateTime.Now.AddHours(random.Next(0, 12))
            });
            ReloadData();
        }

        public void HandleDeleteButtonClicked(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);

            worldClockItems.Remove((WorldClockItemModel)mi.CommandParameter);
            ReloadData();
        }

        void ReloadData()
        {
            lstClocks.ItemsSource = new List<WorldClockItemModel>(worldClockItems);
        }
    }
}