using System;
namespace HanoiDevDays.CrossClock.Models
{
    public class WorldClockItemModel
    {
        public string City { get; set; }
        public int GmtOffset { get; set; }
        public DateTime CurrentTime { get; set; }
    }
}
