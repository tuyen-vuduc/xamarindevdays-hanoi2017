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
        [TestCase("at")]
        [TestCase("ha")]
        [TestCase("am")] 
        public void TestAddTimeZone_RemoveTimeZone(string query)
        {
            Random random = new Random();
            worldClock.AddClock(); 
            worldClockChooser.SearchCity(query); 

            if (worldClockChooser.CountCitiesChilds == 0)
            {
                worldClockChooser.ClearQuery();
            }
            worldClockChooser.SelectCity(random.Next(1, 100) % worldClockChooser.CountCitiesChilds);
            app.WaitForElement(worldClock.ListViewClocks, "waiting for WordClockPage" ,TimeSpan.FromSeconds(1));
            worldClock.DeleteClock(0);
        }
    }
}

