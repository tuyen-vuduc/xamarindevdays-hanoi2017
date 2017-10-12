using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading.Tasks;

namespace HaNoiDevDays.UITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;
        WorldClockPageObject worldClock;
        WorldClockChooserPageObject worldClockChooser;

        string[] querries = {
            "at",
        };

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);

            if (platform == Platform.Android)
            {
                worldClock = new WorldClockPageAndroidObject(app);
            }
            else
            {
                worldClock = new WorldClockPageObjectIOS(app);
            }

            worldClockChooser = new WorldClockChooserPageObject(app);
        }

        [Test]
        public void TestAddFiveClocksSuccess()
        {
            Random random = new Random();
            app.Screenshot("Word Clock screen.");

            worldClock.AddClock();
            app.Screenshot("Word Clock Chooser screen.");

            var query = querries[random.Next(1, 100) % querries.Length];
            worldClockChooser.SearchCity(query);
            app.Screenshot("search city " + query);

            if (worldClockChooser.CountCitiesChilds == 0)
            {
                worldClockChooser.ClearQuerry();
            }

            worldClockChooser.SelectCity(random.Next(1, 100) % worldClockChooser.CountCitiesChilds);
            app.Screenshot("Word Clock screen after add clock.");

            worldClock.DeleteClock(0);
        }
    }
}

