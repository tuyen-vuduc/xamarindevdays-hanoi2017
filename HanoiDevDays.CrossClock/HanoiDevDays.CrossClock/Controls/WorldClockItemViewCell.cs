using System;
using Xamarin.Forms;
using HanoiDevDays.CrossClock.Models;
namespace HanoiDevDays.CrossClock.Controls
{
    public class WorldClockItemViewCell : ViewCell
    {
        public event EventHandler<WorldClockItemModel> DeleteAction;
        
        readonly WorldClockItemView view;

        MenuItem btnDelete;

        public WorldClockItemViewCell()
        {
            view = new WorldClockItemView {
                BackgroundColor = (Color) App.Current.Resources["ColorPrimary"]
            };

            View = view;

            btnDelete = new MenuItem
            {
                Text = "Delete",
                IsDestructive = true,
            };
            btnDelete.Clicked += delegate {
                DeleteAction?.Invoke(this, (WorldClockItemModel)BindingContext);
            };

            ContextActions.Add(btnDelete);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            view.UpdateTime();
        }
    }
}
