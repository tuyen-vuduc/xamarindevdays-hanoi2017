using Xamarin.Forms;
namespace HanoiDevDays.CrossClock.Controls
{
    public class WorldClockItemViewCell : ViewCell
    {
        readonly WorldClockItemView view;

        public WorldClockItemViewCell()
        {
            view = new WorldClockItemView {
                BackgroundColor = (Color) App.Current.Resources["ColorPrimary"]
            };

            View = view;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            view.UpdateTime();
        }
    }
}
