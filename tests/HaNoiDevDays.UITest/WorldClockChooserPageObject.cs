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
        public virtual Func<AppQuery, AppQuery> EntryQuery
        {
            get => c => c.Marked("search_src_text");
        }

        public virtual Func<AppQuery, AppQuery> ButtonClearQuery
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

        protected readonly IApp app;

        public WorldClockChooserPageObject(IApp app)
        {
            this.app = app;
        }

        public void ClearQuery()
        {
            app.Tap(ButtonClearQuery);
        }

        public void SearchCity(string city)
        {
            app.EnterText(EntryQuery, city);
            app.PressEnter();
            app.DismissKeyboard();
        }

        public void SelectCity(int index)
        {
            app.Tap(GetChildAt(index));
        }
    }
}
