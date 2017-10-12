using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace HaNoiDevDays.UITest
{
    public class WorldClockPageObject
    {
        IApp app;
        public virtual Func<AppQuery, AppQuery> MenuItemAdd
        {
            get => c => c.Marked("Add");
        }

        public virtual Func<AppQuery, AppQuery> MenuItemDelete
        {
            get => c => c.Marked("Delete");
        }

        public virtual Func<AppQuery, AppQuery> ListViewClocks
        {
            get => c => c.Marked("lstClocks");
        }

        public virtual Func<AppQuery, AppQuery> ClockChilds
        {
            get => c => c.Marked("lstClocks").Child();
        }

        public virtual Func<AppQuery, AppQuery> GetChildAt(int index)
        {
            return c => c.Marked("lstClocks").Child(index);
        }

        public virtual int ClocksCount
        {
            get => app.Query(ClockChilds).Count();
        }

        public WorldClockPageObject(IApp app)
        {
            this.app = app;
        }

        public void AddClock()
        {
            app.Tap(MenuItemAdd);
        }

        public virtual void DeleteClock(int index)
        {

        }
    }
}
