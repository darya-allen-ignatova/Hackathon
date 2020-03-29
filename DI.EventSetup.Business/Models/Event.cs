using DI.EventSetup.Business.Models.Enumerations;
using System;

namespace DI.EventSetup.Business.Models
{
    public class Event
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public Status Status { get; set; }

        public int DirectionId { get; set; }

        public int CityId { get; set; }

        public int LogoId { get; set; }
    }
}
