using System;
using System.Collections.Generic;
using Xamarin.Forms;
using HanoiDevDays.CrossClock.Models;

namespace HanoiDevDays.CrossClock.Controls
{
    public partial class WorldClockItemViewCell : ViewCell
    {
        bool shouldContinueTimer;

        public WorldClockItemViewCell()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (shouldContinueTimer == false)
            {
                shouldContinueTimer = true;
                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    if (BindingContext is WorldClockItemModel model)
                    {
                        model.UpdateTime();
                    }
                    return shouldContinueTimer;
                });
            }
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            shouldContinueTimer = false;
        }
    }
}
