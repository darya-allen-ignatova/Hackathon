using Caliburn.Micro;
using DI.EventSetup.Business.DataAccess;
using DI.EventSetup.Business.Models;
using DI.EventSetup.Business.Services;
using DI.EventSetup.UI.Main;

namespace DI.EventSetup.UI.Configuration
{
    public static class DependenciesConfigurator
    {
        public static void AddAllDependencies(this SimpleContainer container)
        {
            container.AddStaticDependencies();
            container.AddServicesDependencies();
            container.AddRepositoryDependencies();
        }

        private static void AddStaticDependencies(this SimpleContainer container)
        {
            container.PerRequest<MainViewModel>();
            container.PerRequest<IWindowManager, WindowManager>();
        }

        private static void AddServicesDependencies(this SimpleContainer container)
        {
            container.PerRequest<IServiceBase<Activity>, ServiceBase<Activity>>();
            container.PerRequest<IServiceBase<ActivityFiles>, ServiceBase<ActivityFiles>>();
            container.PerRequest<IServiceBase<ActivityResults>, ServiceBase<ActivityResults>>();
            container.PerRequest<IServiceBase<City>, ServiceBase<City>>();
            container.PerRequest<IServiceBase<Country>, ServiceBase<Country>>();
            container.PerRequest<IServiceBase<Direction>, ServiceBase<Direction>>();
            container.PerRequest<IServiceBase<Event>, ServiceBase<Event>>();
            container.PerRequest<IServiceBase<EventUserRole>, ServiceBase<EventUserRole>>();
            container.PerRequest<IServiceBase<File>, ServiceBase<File>>();
            container.PerRequest<IServiceBase<Group>, ServiceBase<Group>>();
            container.PerRequest<IServiceBase<LoginInfo>, ServiceBase<LoginInfo>>();
            container.PerRequest<IServiceBase<Task>, ServiceBase<Task>>();
            container.PerRequest<IServiceBase<User>, ServiceBase<User>>();
            container.PerRequest<IServiceBase<UserGroup>, ServiceBase<UserGroup>>();
            container.PerRequest<IEventService, EventService>(); 
        }

        private static void AddRepositoryDependencies(this SimpleContainer container)
        {
            container.PerRequest<IRepository<Activity>, Repository<Activity>>();
            container.PerRequest<IRepository<ActivityFiles>, Repository<ActivityFiles>>();
            container.PerRequest<IRepository<ActivityResults>, Repository<ActivityResults>>();
            container.PerRequest<IRepository<City>, Repository<City>>();
            container.PerRequest<IRepository<Country>, Repository<Country>>();
            container.PerRequest<IRepository<Direction>, Repository<Direction>>();
            container.PerRequest<IRepository<Event>, Repository<Event>>();
            container.PerRequest<IRepository<EventUserRole>, Repository<EventUserRole>>();
            container.PerRequest<IRepository<File>, Repository<File>>();
            container.PerRequest<IRepository<Group>, Repository<Group>>();
            container.PerRequest<IRepository<LoginInfo>, Repository<LoginInfo>>();
            container.PerRequest<IRepository<Task>, Repository<Task>>();
            container.PerRequest<IRepository<User>, Repository<User>>();
            container.PerRequest<IRepository<UserGroup>, Repository<UserGroup>>();
        }
    }
}
