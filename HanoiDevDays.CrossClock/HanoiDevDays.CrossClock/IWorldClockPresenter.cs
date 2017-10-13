using System.Collections.Generic;
using HanoiDevDays.CrossClock.DTOs;
using HanoiDevDays.CrossClock.Models;
namespace HanoiDevDays.CrossClock
{
    public interface IWorldClockPage
    {
        void UpdateListView();
    }

    public interface IWorldClockPagePresenter
    {
        IReadOnlyCollection<WorldClockItemModel> Clocks { get; }

        void RemoveClock(WorldClockItemModel clock);
        void AddClock(TimeZoneDto clock);

        void OnAppearing();
        void OnDisappearing();
    }
}

