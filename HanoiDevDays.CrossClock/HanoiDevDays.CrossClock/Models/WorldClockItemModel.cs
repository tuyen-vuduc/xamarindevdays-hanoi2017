using System;
namespace HanoiDevDays.CrossClock.Models
{
    public class WorldClockItemModel
    {
        public string City { get; set; }
        public int TimeZone { get; set; }
        public DateTime CurrentTime { get; set; }
    }
}
