using Caliburn.Micro;
using DI.EventSetup.Business.Services;
using DI.EventSetup.UI.Controls.EventListView;

namespace DI.EventSetup.UI.Main
{
    public class MainViewModel : Screen
    {
        private readonly IEventService _eventService;
        private EventListViewModel _eventListViewModels;

        public MainViewModel(IEventService eventService)
        {
            _eventService = eventService;
        }

        protected override void OnInitialize()
        {
            base.OnInitialize();
            var eventList = _eventService.GetFullEventInfos();
            _eventListViewModels = new EventListViewModel(eventList);
        }

        public EventListViewModel EventListViewModels
        {
            get => _eventListViewModels;
            set => Set(ref _eventListViewModels, value);
        }
    }
}
