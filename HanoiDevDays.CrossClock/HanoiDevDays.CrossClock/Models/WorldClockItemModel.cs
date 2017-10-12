using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HanoiDevDays.CrossClock.Models
{
    public class WorldClockItemModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string City { get; set; }
        public int GmtOffset { get; set; }
        public DateTime ZoneTime
        {
            get => DateTime.Now.ToUniversalTime().AddTicks(GmtOffset);
        }

        internal void UpdateTime()
        {
            RaisePropertyChanged(nameof(ZoneTime));
        }

        void RaisePropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
