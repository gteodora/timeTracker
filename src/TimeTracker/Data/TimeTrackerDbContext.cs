using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Domain;

namespace TimeTracker.Data
{
    public class TimeTrackerDbContext : DbContext
    {
        public TimeTrackerDbContext(DbContextOptions<TimeTrackerDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TimeEntry> TimeEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasData(
                new User { id = 1, name = "User 1", HourRate = 15m },
                new User { id = 2, name = "User 2", HourRate = 20m });

            modelBuilder.Entity<Client>().HasData(
               new Client { id = 1, name = "Client 1" },
               new Client { id = 2, name = "Client 2" });

            modelBuilder.Entity<Project>().HasData(
                new  { id = 1L, name = "Project 1", Clientid = 1L },
                new  { id = 2L, name = "Project 2", Clientid = 1L },
                new  { id = 3L, name = "Project 3", Clientid = 2L });
        }
    }
}
