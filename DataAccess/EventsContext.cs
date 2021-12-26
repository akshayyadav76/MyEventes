using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EventsContext : DbContext
    {
        public EventsContext(DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    /*    public DbSet<City> Citys { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<User> Users { get; set; }*/
        public DbSet<Event> Events { get; set; }
   /*     public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<EventUser> EventUsers { get; set; }
        public DbSet<EventTag> EventTags { get; set; }*/
    }
}
