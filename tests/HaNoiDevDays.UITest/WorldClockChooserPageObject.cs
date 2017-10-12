using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace HaNoiDevDays.UITest
{
    public class WorldClockChooserPageObject
    {
        IApp app;
        public virtual Func<AppQuery, AppQuery> EntryQuerry
        {
            get => c => c.Marked("search_src_text");
        }

        public virtual Func<AppQuery, AppQuery> ButtonClearQuerry
        {
            get => c => c.Marked("Clear query");
        }

        public virtual Func<AppQuery, AppQuery> ListViewCities
        {
            get => c => c.Marked("lstCities");
        }

        public virtual Func<AppQuery, AppQuery> ListViewCitiesChilds
        {
            get => c => c.Marked("lstCities").Child();
        }

        public virtual Func<AppQuery, AppQuery> GetChildAt(int index)
        {
            return c => c.Marked("lstCities").Child(index);
        }

        public virtual int CountCitiesChilds
        {
            get => app.Query(ListViewCitiesChilds).Count();
        }

        public void ClearQuerry()
        {
            app.Tap(ButtonClearQuerry);
        }

        public WorldClockChooserPageObject(IApp app)
        {
            this.app = app;
        }

        public void SearchCity(string city)
        {
            app.EnterText(EntryQuerry, city);
            app.PressEnter();
            app.DismissKeyboard();
        }

        public void SelectCity(int index)
        {
            app.Tap(GetChildAt(index));
        }
    }
}
