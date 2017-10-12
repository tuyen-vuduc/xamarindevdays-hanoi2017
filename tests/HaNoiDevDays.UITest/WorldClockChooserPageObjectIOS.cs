using System;
using Xamarin.UITest;
namespace HaNoiDevDays.UITest
{
    public class WorldClockChooserPageObjectIOS : WorldClockChooserPageObject
    {
        public override Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery> EntryQuerry
        {
            get => c => c.Marked("txtQuery");
        }

        public WorldClockChooserPageObjectIOS(IApp app) : base(app)
        {
        }
    }
}
