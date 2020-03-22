using DI.EventSetup.Business.Models.Enumerations;
using System;

namespace DI.EventSetup.Business.Models
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int LoginId { get; set; }

        public int CityId { get; set; }

        public int ImageId { get; set; }

        public Gender Gender { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
