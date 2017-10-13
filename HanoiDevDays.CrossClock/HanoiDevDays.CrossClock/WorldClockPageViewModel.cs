using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;
using HanoiDevDays.CrossClock.Models;
using System.Windows.Input;
using Xamarin.Forms;
using HanoiDevDays.CrossClock.DTOs;
using System.Linq;

namespace HanoiDevDays.CrossClock
{
    public class WorldClockPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        ObservableCollection<WorldClockItemModel> _Clocks;
        public ObservableCollection<WorldClockItemModel> Clocks
        {
            get => _Clocks;
            set => SetProperty(ref _Clocks, value);
        }

        public WorldClockPageViewModel()
        {
            Clocks = new ObservableCollection<WorldClockItemModel>();
        }

        void SetProperty<T>(ref T backingField, T value, [CallerMemberName]string propertyName = null)
        {
            if (false == object.Equals(backingField, value))
            {
                backingField = value;

                RaisePropertyChanged(propertyName);
            }
        }

        void RaisePropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        ICommand _AddClockCommand;
        public ICommand AddClockCommand
        {
            get { return (_AddClockCommand = _AddClockCommand ?? new Command<TimeZoneDto>(ExecuteAddClockCommand, CanExecuteAddClockCommand)); }
        }
        bool CanExecuteAddClockCommand(TimeZoneDto timeZone) => false == Clocks.Any(x => timeZone.ZoneName.EndsWith($"/{x.City}", StringComparison.OrdinalIgnoreCase));
        void ExecuteAddClockCommand(TimeZoneDto timeZone)
        {
            Clocks.Add(new WorldClockItemModel
            {
                GmtOffset = timeZone.GmtOffset,
                City = timeZone.ZoneName.Split('/').Last()
            });
        }

        ICommand _DeleteClockCommand;
        public ICommand DeleteClockCommand
        {
            get { return (_DeleteClockCommand = _DeleteClockCommand ?? new Command<object>(ExecuteDeleteClockCommand, CanExecuteDeleteClockCommand)); }
        }
        bool CanExecuteDeleteClockCommand(object obj) { return true; }
        void ExecuteDeleteClockCommand(object obj)
        {
            Clocks.Remove((WorldClockItemModel)obj);
        }
    }
}
