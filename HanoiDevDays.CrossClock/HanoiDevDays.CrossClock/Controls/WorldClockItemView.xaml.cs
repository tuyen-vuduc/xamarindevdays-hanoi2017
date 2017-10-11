
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using HanoiDevDays.CrossClock.Models;

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
            lblCurrentTime.Text = worldClockItemModel.CurrentTime.ToString("hh:mm");
            lblAMPM.Text = worldClockItemModel.CurrentTime.Hour > 12 ? "PM" : "AM";
        }
    }
}