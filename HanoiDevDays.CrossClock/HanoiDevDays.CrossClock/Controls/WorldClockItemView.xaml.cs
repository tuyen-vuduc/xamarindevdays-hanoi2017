
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using HanoiDevDays.CrossClock.Models;
using System;

namespace HanoiDevDays.CrossClock.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorldClockItemView : ContentView
    {
        public WorldClockItemView()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var worldClockItemModel = (WorldClockItemModel)BindingContext;

            lblCity.Text = worldClockItemModel.City;

            UpdateTime();
        }

        internal void UpdateTime()
        {
            var worldClockItemModel = (WorldClockItemModel)BindingContext;

            var zoneDate = DateTime.Now.ToUniversalTime().AddTicks(worldClockItemModel.GmtOffset);

            lblCurrentTime.Text = zoneDate.ToString("hh:mm");

            lblAMPM.Text = zoneDate.Hour > 12 ? "PM" : "AM";

            var diff = zoneDate - DateTime.Now;
            lblZone.Text = diff.Hours > 0
                ? $"Today, +{diff.Hours.ToString("D2")}HRS"
                : $"Today, {diff.Hours.ToString("D2")}HRS";
        }
    }
}