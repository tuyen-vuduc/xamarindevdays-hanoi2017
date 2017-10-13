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
    public partial class WorldClockPage : ContentPage, IWorldClockPage
    {
        IWorldClockPagePresenter presenter;

        public WorldClockPage()
        {
            InitializeComponent();

            presenter = new WorldClockPagePresenter(this);

            lstClocks.ItemSelected += delegate
            {
                lstClocks.SelectedItem = null;
            };
            btnAdd.Clicked += HandleAddButtonClicked;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            presenter.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            presenter.OnDisappearing();
        }

        async void HandleAddButtonClicked(object sender, EventArgs e)
        {
            var chooserPage = new WorldClockChooserPage();
            chooserPage.TimeZoneSelected += HandleTimeZomeSelected;
            await Navigation.PushAsync(chooserPage);
        }

        public void HandleDeleteButtonClicked(object sender, WorldClockItemModel item)
        {
            presenter.RemoveClock(item);
        }

        void HandleTimeZomeSelected(object sender, TimeZoneDto timeZone)
        {
            presenter.AddClock(timeZone);
        }

        public void UpdateListView()
        {
            lstClocks.ItemsSource = new List<WorldClockItemModel>(presenter.Clocks);
        }
    }
}