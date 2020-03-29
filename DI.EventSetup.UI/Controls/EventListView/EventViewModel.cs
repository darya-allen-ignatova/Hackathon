using DI.EventSetup.Business.ReadModels;
using DI.EventSetup.UI.Configuration;
using System;

namespace DI.EventSetup.UI.Controls.EventListView
{
    public class EventViewModel : EntityModel<EventModel>
    {
        public EventViewModel(EventModel ev) : base(ev)
        {
        }

        public int Id => Model.Event.Id;

        public string Name => Model.Event.Name;

        public string Direction => Model.Direction.Name;

        public DateTime Date => Model.Event.StartDateTime.Date;

        public byte[] Logo => Model.Logo.Data;
    }
}
