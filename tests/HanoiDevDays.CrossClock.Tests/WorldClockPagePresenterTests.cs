using NUnit.Framework;
using NSubstitute;
using System.Linq;
namespace HanoiDevDays.CrossClock.Tests
{
    [TestFixture]
    public class WorldClockPagePresenterTests
    {

        WorldClockPageViewModel viewModel;

        [SetUp]
        protected void Setup()
        {
            viewModel = new WorldClockPageViewModel();
        }

        [TearDown]
        protected void TearDown()
        {
        }

        [Test]
        public void AddClockCommand_CanExecute_ReturnTrue()
        {
            var result = viewModel.AddClockCommand.CanExecute(new DTOs.TimeZoneDto
            {
                ZoneName = "/Hanoi",
                GmtOffset = 111111
            });

            Assert.IsTrue(result);
        }

        [Test]
        public void AddClockCommand_Execute_Normal()
        {
            viewModel.AddClockCommand.Execute(new DTOs.TimeZoneDto
            {
                ZoneName = "/Hanoi",
                GmtOffset = 111111
            });

            Assert.AreEqual(viewModel.Clocks.Count, 1);
        }

        [Test]
        public void AddClockCommand_CanExecute_ReturnFalse()
        {
            viewModel.AddClockCommand.Execute(new DTOs.TimeZoneDto
            {
                ZoneName = "/Hanoi",
                GmtOffset = 111111
            });

            var result = viewModel.AddClockCommand.CanExecute(new DTOs.TimeZoneDto
            {
                ZoneName = "/Hanoi",
                GmtOffset = 111111
            });

            Assert.IsFalse(result);
            Assert.AreEqual(viewModel.Clocks.Count, 1);
        }

        [Test]
        public void DeleteClockCommand_Normal()
        {
            viewModel.AddClockCommand.Execute(new DTOs.TimeZoneDto
            {
                ZoneName = "/Hanoi",
                GmtOffset = 111111
            });

            viewModel.DeleteClockCommand.Execute(viewModel.Clocks[0]);
            Assert.AreEqual(viewModel.Clocks.Count, 0);
        }
    }
}
