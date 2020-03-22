using DI.EventSetup.Business.Models.Enumerations;

namespace DI.EventSetup.Business.Models
{
    public class EventUserRole
    {
        public int UserId { get; set; }

        public int EventId { get; set; }

        public Role Role { get; set; }
    }
}
