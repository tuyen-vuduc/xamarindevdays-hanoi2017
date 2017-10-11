using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HanoiDevDays.CrossClock
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorldClock : ContentPage
    {
        public WorldClock()
        {
            InitializeComponent();

            lstClocks.ItemsSource = new string[12];
        }
    }
}