using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DemoTimePicker.UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;
        MainPageObject mainPage;

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
            if (platform == Platform.Android)
            {
                mainPage = new MainPageObjectAndroid(app);
            }
            else
            {
                mainPage = new MainPageObjectIOS(app);
            }
        }

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [Test]
        [TestCase(4,15,true,"4:15 AM")]
        [TestCase(6, 25, true, "6:25 AM")]
        [TestCase(1, 20, false, "1:20 PM")]
        public void TestChooseTime(int hour,int minute,bool isAM,string output)
        {
            app.Tap(mainPage.TimePicker);
            mainPage.ChooseTime(hour, minute, isAM); 
            Assert.True(app.Query(c => c.Text(output)).Length > 0);
        }
    }
}

