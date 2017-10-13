using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DemoTimePicker.UITest
{

    public class MainPageObjectAndroid : MainPageObject
    {
        public override Func<AppQuery, AppQuery> TimePicker => c => c.Marked("picker");
        public override Func<AppQuery, AppQuery> LabelHours => c => c.Marked("hours");
        public override Func<AppQuery, AppQuery> LabelPM => c => c.Marked("pm_label");
        public override Func<AppQuery, AppQuery> LabelAM => c => c.Marked("am_label");
        public override Func<AppQuery, AppQuery> LabelMinutes => c => c.Marked("minutes");
        public override Func<AppQuery, AppQuery> RadialTime => c => c.Marked("radial_picker");
        public override Func<AppQuery, AppQuery> ButtonCancel => c => c.Marked("button2");
        public override Func<AppQuery, AppQuery> ButtonOK => c => c.Marked("button1");

        public MainPageObjectAndroid(IApp app) : base(app)
        {
        }


        public override void ChooseTime(int hour, int minute, bool isAM)
        {
            app.Tap(LabelHours);
            var radials = app.Query(RadialTime);
            if (radials.Length == 0)
                return;
            AppResult radial = radials[0];
            float centerX = radial.Rect.CenterX;
            float centerY = radial.Rect.CenterY;
            float x = radial.Rect.X;
            float y = radial.Rect.Y;

            float r = (centerX - x) > (centerY - y) ? (centerY - y) : (centerX - x);

            float hX = centerX + (float)Math.Sin(hour * Math.PI / 6) * r;
            float hY = centerY - (float)Math.Cos(hour * Math.PI / 6) * r;

           


            float mX = centerX + (float)Math.Sin(minute * Math.PI / 30) * r;
            float mY = centerY - (float)Math.Cos(minute * Math.PI / 30) * r;

            hX = hX == centerX ? hX : hX > centerX ? hX - 2 : hX + 2;
            hY = hY == centerY ? hY : hY > centerY ? hY - 2 : hY + 2;
            mX = hX == centerX ? mX : mX > centerX ? mX - 2 : mX + 2;
            mY = mY == centerY ? mY : mY > centerY ? mY - 2 : mY + 2;

            app.TapCoordinates(hX, hY);
            app.Tap(LabelMinutes);
            app.TapCoordinates(mX, mY);
            if (isAM)
            {
                app.Tap(LabelAM);
            }
            else
            {
                app.Tap(LabelPM);
            }
            app.Tap(ButtonOK);
        }

        public override void ChooseHour(int hour)
        {
            app.Tap(LabelHours);
            var radials = app.Query(RadialTime);
            if (radials.Length == 0)
                return;
            AppResult radial = radials[0];
            float centerX = radial.Rect.CenterX;
            float centerY = radial.Rect.CenterY;
            float x = radial.Rect.X;
            float y = radial.Rect.Y;

            float r = (centerX - x) > (centerY - y) ? (centerY - y) : (centerX - x);

            float realX = centerX + (float)Math.Sin(hour * Math.PI / 6) * r;
            float realY = centerY - (float)Math.Cos(hour * Math.PI / 6) * r;
            app.TapCoordinates(realX, realY);
        }


        public override void ChooseMinute(int minute)
        {
            app.Tap(LabelMinutes);
            var radials = app.Query(RadialTime);
            if (radials.Length == 0)
                return;
            AppResult radial = radials[0];
            float centerX = radial.Rect.CenterX;
            float centerY = radial.Rect.CenterY;
            float x = radial.Rect.X;
            float y = radial.Rect.Y;

            float r = (centerX - x) > (centerY - y) ? (centerY - y) : (centerX - x);

            float realX = centerX + (float)Math.Sin(minute * Math.PI / 30) * r;
            float realY = centerY - (float)Math.Cos(minute * Math.PI / 30) * r;
            app.TapCoordinates(realX, realY);
        }
    }
}
