using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;

namespace HaNoiDevDays.UITest
{
    public class WorldClockPageAndroidObject : WorldClockPageObject
    {
        IApp app;
        public WorldClockPageAndroidObject(IApp app) : base(app)
        {
            this.app = app;
        }

        public override void DeleteClock(int index)
        {
            app.TouchAndHold(GetChildAt(index));
            app.Tap(MenuItemDelete);
        }
    }
}
