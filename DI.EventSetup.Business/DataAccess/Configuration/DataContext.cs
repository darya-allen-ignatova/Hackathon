using DI.EventSetup.Business.Models;
using System.Data.Entity;

namespace DI.EventSetup.Business.DataAccess.Configuration
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Default")
        {
        }

        public DbSet<Activity> Activities { get; set; }

        public DbSet<ActivityFiles> ActivityFiles { get; set; }

        public DbSet<ActivityResults> ActivityResults { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Direction> Directions { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<EventUserRole> EventUserRoles { get; set; }

        public DbSet<File> Files { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<LoginInfo> LoginInfos { get; set; }

        public DbSet<Task> Tasks { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserGroup> UserGroups { get; set; }
    }
}
