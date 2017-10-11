using System;
namespace HanoiDevDays.CrossClock.DTOs
{
    public class TimeZoneDto
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string ZoneName { get; set; }
        public long Timestamp { get; set; }
        public int GmtOffset { get; set; }
    }
}
