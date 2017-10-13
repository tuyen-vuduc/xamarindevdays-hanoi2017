using NUnit.Framework;
using NSubstitute;
using System.Linq;
namespace HanoiDevDays.CrossClock.Tests
{
    [TestFixture]
    public class WorldClockPagePresenterTests
    {
        IWorldClockPage pageMock;
        WorldClockPagePresenter presenter;

        [SetUp]
        protected void Setup()
        {
            pageMock = Substitute.For<IWorldClockPage>();

            presenter = new WorldClockPagePresenter(pageMock);
        }

        [TearDown]
        protected void TearDown()
        {
        }

        [Test]
        public void AddNewClock_Normal()
        {
            presenter.AddClock(new DTOs.TimeZoneDto
            {
                ZoneName = "/Hanoi",
                GmtOffset = 111111
            });

            Assert.AreEqual(presenter.Clocks.Count, 1);

            pageMock.Received().UpdateListView();
        }

        [Test]
        [TestCase(1)]
        [TestCase(2)]
        public void AddNewClock_ShouldNotDuplicateZone(int duplicateCount)
        {
            presenter.AddClock(new DTOs.TimeZoneDto
            {
                ZoneName = "/Hanoi",
                GmtOffset = 111111
            });

            for (int i = 0; i < duplicateCount; i++)
            {
                presenter.AddClock(new DTOs.TimeZoneDto
                {
                    ZoneName = "/Hanoi",
                    GmtOffset = 111111
                });
            }

            Assert.AreEqual(presenter.Clocks.Count, 1);

            pageMock.Received().UpdateListView();
        }

        [Test]
        public void RemoveClock_Success()
        {
            presenter.AddClock(new DTOs.TimeZoneDto
            {
                ZoneName = "/Hanoi",
                GmtOffset = 111111
            });
            presenter.RemoveClock(presenter.Clocks.First());

            Assert.AreEqual(presenter.Clocks.Count, 0);

            pageMock.Received().UpdateListView();
        }
    }
}
