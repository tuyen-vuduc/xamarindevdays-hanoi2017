
using System;
using HanoiDevDays.CrossClock.DTOs;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HanoiDevDays.CrossClock
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorldClockPage : ContentPage
    {
        readonly WorldClockPageViewModel viewModel;

        public WorldClockPage()
        {
            InitializeComponent();

            lstClocks.ItemSelected += delegate
            {
                lstClocks.SelectedItem = null;
            };
            btnAdd.Clicked += async delegate
            {
                var chooserPage = new WorldClockChooserPage();
                chooserPage.TimeZoneSelected += HandleTimeZomeSelected;
                await Navigation.PushModalAsync(chooserPage);
            };

            viewModel = new WorldClockPageViewModel();
            BindingContext = viewModel;
        }

        void HandleTimeZomeSelected(object sender, TimeZoneDto timeZone)
        {
            if (viewModel.AddClockCommand?.CanExecute(timeZone) == true)
            {
                viewModel.AddClockCommand.Execute(timeZone);
            }
        }
    }
}