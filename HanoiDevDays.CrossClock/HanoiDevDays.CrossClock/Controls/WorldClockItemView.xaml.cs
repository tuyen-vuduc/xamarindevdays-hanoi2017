
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HanoiDevDays.CrossClock.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorldClockItemView : ContentView
    {
        public WorldClockItemView()
        {
            InitializeComponent();
        }

        internal void UpdateTime()
        {
            OnBindingContextChanged();
        }
    }
}