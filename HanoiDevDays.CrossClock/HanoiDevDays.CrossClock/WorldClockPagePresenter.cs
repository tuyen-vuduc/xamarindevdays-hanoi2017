using System;
using System.Collections.Generic;
using HanoiDevDays.CrossClock.DTOs;
using HanoiDevDays.CrossClock.Models;
using System.Linq;

namespace HanoiDevDays.CrossClock
{
    public class WorldClockPagePresenter : IWorldClockPagePresenter
    {
        List<WorldClockItemModel> _Clocks;
        public IReadOnlyCollection<WorldClockItemModel> Clocks => _Clocks;

        readonly IWorldClockPage page;

        public WorldClockPagePresenter(IWorldClockPage page)
        {
            this.page = page;
            _Clocks = new List<WorldClockItemModel>();
        }

        public void AddClock(TimeZoneDto zone)
        {
            var exists = _Clocks.Any(x => zone.ZoneName.EndsWith($"/{x.City}", StringComparison.OrdinalIgnoreCase));

            if (exists)
            {
                return;
            }

            _Clocks.Add(new WorldClockItemModel
            {
                City = zone.ZoneName.Split('/').Last(),
                GmtOffset = zone.GmtOffset
            });
            page.UpdateListView();
        }

        public void OnAppearing()
        {
        }

        public void OnDisappearing()
        {
        }

        public void RemoveClock(WorldClockItemModel clock)
        {
            _Clocks.Remove(clock);
            page.UpdateListView();
        }
    }
}
