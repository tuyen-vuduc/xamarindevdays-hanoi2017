
using Xamarin.Forms;

namespace HanoiDevDays.CrossClock
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new WorldClockPage())
            {
                BarBackgroundColor = (Color)Resources["ColorPrimary"],
                BarTextColor = (Color)Resources["ColorTextPrimary"]
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
