using System;

namespace DI.EventSetup.Business.Models
{
    public class Activity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public int EventId { get; set; }
    }
}
