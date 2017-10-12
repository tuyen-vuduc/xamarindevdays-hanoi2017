using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using HanoiDevDays.CrossClock.DTOs;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Linq;
using System.Threading.Tasks;

namespace HanoiDevDays.CrossClock
{
    public class WorldClockChooserPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        IList<TimeZoneDto> _Cities;
        public IList<TimeZoneDto> Cities
        {
            get => _Cities;
            set => SetProperty(ref _Cities, value);
        }

        string _Query;
        public string Query
        {
            get => _Query;
            set => SetProperty(ref _Query, value);
        }

        public WorldClockChooserPageViewModel(INavigation navigation)
        {
            SearchCommand.Execute(null);
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

        ICommand _SearchCommand;
        public ICommand SearchCommand
        {
            get { return (_SearchCommand = _SearchCommand ?? new Command<object>(ExecuteSearchCommand, CanExecuteSearchCommand)); }
        }
        bool CanExecuteSearchCommand(object obj) { return true; }
        async void ExecuteSearchCommand(object obj)
        {
            await Task.Run(() =>
            {
                var query = Query?.ToUpper() ?? string.Empty;
                Cities = TimeZoneData
                    .GetTimeZones()
                    .Where(x => x.ZoneName.ToUpper().Contains(query))
                    .ToList();
            });
        }
    }
}
