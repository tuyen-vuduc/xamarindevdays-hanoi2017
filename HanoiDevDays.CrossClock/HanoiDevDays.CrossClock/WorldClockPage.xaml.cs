
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HanoiDevDays.CrossClock
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorldClockPage : ContentPage
    {
        public WorldClockPage()
        {
            InitializeComponent();

            lstClocks.ItemSelected += delegate
            {
                lstClocks.SelectedItem = null;
            };

            BindingContext = new WorldClockPageViewModel(Navigation);
        }
    }
}