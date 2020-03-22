﻿namespace DI.EventSetup.Business.Models
{
    public class Task
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ActivityId { get; set; }

        public int GroupId { get; set; }
    }
}
