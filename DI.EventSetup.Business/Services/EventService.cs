using DI.EventSetup.Business.DataAccess;
using DI.EventSetup.Business.Models;
using DI.EventSetup.Business.ReadModels;
using System.Collections.Generic;
using System.Linq;

namespace DI.EventSetup.Business.Services
{
    public interface IEventService
    {
        List<EventModel> GetFullEventInfos();
    }

    public class EventService : ServiceBase<Event>, IEventService
    {
        private readonly IRepository<Direction> _directionRepository;
        private readonly IRepository<City> _cityRepository;
        private readonly IRepository<File> _fileRepository;

        public EventService(
            IRepository<Event> repository,
            IRepository<Direction> directionRepository,
            IRepository<City> cityRepository,
            IRepository<File> fileRepository) 
            : base(repository)
        {
            _cityRepository = cityRepository;
            _fileRepository = fileRepository;
            _directionRepository = directionRepository;
        }

        public List<EventModel> GetFullEventInfos()
        {
            var list = from ev in Repository.GetAll()
                       join direction in _directionRepository.GetAll() on ev.DirectionId equals direction.Id
                       join city in _cityRepository.GetAll() on ev.CityId equals city.Id
                       join file in _fileRepository.GetAll() on ev.LogoId equals file.Id into logos
                       from logo in logos.DefaultIfEmpty()
                       select new EventModel
                       {
                           Event = ev,
                           City = city,
                           Direction = direction,
                           Logo = logo
                       };

            return list.ToList();
        }
    }
}
