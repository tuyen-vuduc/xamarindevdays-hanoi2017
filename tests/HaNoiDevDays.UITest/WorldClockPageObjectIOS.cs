using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace HaNoiDevDays.UITest
{
    public class WorldClockPageObjectIOS : WorldClockPageObject
    {
        public override Func<AppQuery, AppQuery> MenuItemAdd
        {
            get => c => c.Marked("btnAdd");
        }

        public WorldClockPageObjectIOS(IApp app) : base(app)
        {
        }

        public override void DeleteClock(int index)
        {
            app.SwipeRightToLeft(GetChildAt(index));
            app.Tap(MenuItemDelete);
        }
    }
}
