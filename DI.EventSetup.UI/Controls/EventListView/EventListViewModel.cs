using Caliburn.Micro;
using DI.EventSetup.Business.ReadModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DI.EventSetup.UI.Controls.EventListView
{
    public class EventListViewModel : Screen
    {
        private List<EventViewModel> _events;
        private string _selectedDirection;
        private DateTime? _selectedDate;

        public EventListViewModel(List<EventModel> events)
        {
            _events = events.Select(x => new EventViewModel(x)).ToList();
            NotifyOfPropertyChange(nameof(Directions));
            NotifyOfPropertyChange(nameof(Dates));
        }

        public List<EventViewModel> Events => GetEventsBySelectedParameters();

        public List<string> Directions => Events.Select(x => x.Direction).ToList();

        public string SelectedDirection
        {
            get => _selectedDirection;
            set => Set(ref _selectedDirection, value);
        }

        public List<DateTime> Dates => Events.Select(x => x.Date).ToList();

        public DateTime? SelectedDate
        {
            get => _selectedDate;
            set => Set(ref _selectedDate, value);
        }

        private List<EventViewModel> GetEventsBySelectedParameters()
        {
            return _events.Where(x => (string.IsNullOrWhiteSpace(SelectedDirection) || x.Direction.Equals(SelectedDirection, StringComparison.CurrentCulture))
                                      && (SelectedDate == null || x.Date == SelectedDate)).ToList();
        }
    }
}
