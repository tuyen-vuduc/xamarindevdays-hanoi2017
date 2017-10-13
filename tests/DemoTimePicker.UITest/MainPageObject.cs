using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DemoTimePicker.UITest
{
    public class MainPageObject
    {
        protected readonly IApp app;
         
        public virtual Func<AppQuery, AppQuery> TimePicker
        {
            get => c => c.Marked("");
        }
        public virtual Func<AppQuery, AppQuery> LabelHours
        {
            get => c => c.Marked("");
        }

        public virtual Func<AppQuery, AppQuery> LabelPM
        {
            get => c => c.Marked("");
        }

        public virtual Func<AppQuery, AppQuery> LabelAM
        {
            get => c => c.Marked("");
        }

        public virtual Func<AppQuery, AppQuery> LabelMinutes
        {
            get => c => c.Marked("");
        }
        public virtual Func<AppQuery, AppQuery> RadialTime
        {
            get => c => c.Marked("");
        }
        public virtual Func<AppQuery, AppQuery> ButtonOK
        {
            get => c => c.Marked("");
        }
        public virtual Func<AppQuery, AppQuery> ButtonCancel
        {
            get => c => c.Marked("");
        }

        public MainPageObject(IApp app)
        {
            this.app = app;
        }

        public virtual void ChooseTime(int hour, int minute, bool isAM)
        { 
        }

        public virtual void ChooseHour(int hour)
        { 
        }


        public virtual void ChooseMinute(int minute)
        { 
        } 
    }
}
