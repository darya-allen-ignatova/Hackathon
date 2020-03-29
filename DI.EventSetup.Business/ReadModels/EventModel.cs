using DI.EventSetup.Business.Models;

namespace DI.EventSetup.Business.ReadModels
{
    public class EventModel
    {
        public Event Event { get; set; }

        public Direction Direction { get; set; }

        public City City { get; set; }

        public File Logo { get; set; }
    }
}
