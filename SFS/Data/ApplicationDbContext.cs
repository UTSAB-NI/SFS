
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SFS.Models;

namespace SFS.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)

        {

        }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
       


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Class>().HasData(
            //    new Class {ClassId = 1, Name = "Pilates", Description="Do Pilates to stay healthy for a long time." },
            //     new Class { ClassId = 2, Name = "Yoga", Description = "Do yoga to be in sync with nature." },
            //      new Class { ClassId = 3, Name = "HIW", Description = "Do High Intensity Workout to gain Muscles." }
            //    );

            //modelBuilder.Entity<Teacher>().HasData(
            //    new Teacher { TeacherId = 1, Name = "Alice Johnson", Expertise = "Yoga" },
            //    new Teacher { TeacherId = 2, Name = "Bob Smith", Expertise = "Pilates" },
            //    new Teacher { TeacherId = 3, Name = "Charlie Brown", Expertise = "HIW" }
            //);
            //// Seeding Schedule data
            //modelBuilder.Entity<Schedule>().HasData(
            //    new Schedule
            //    {
            //        ScheduleId = 1,
            //        StartTime = new DateTime(2024, 9, 10, 9, 0, 0),  // Example: September 10, 2024 at 09:00 AM
            //        EndTime = new DateTime(2024, 9, 10, 10, 0, 0),    // Example: September 10, 2024 at 10:00 AM
            //        MaxCapacity = 20,
            //        ClassId = 1,
            //        TeacherId = 1
            //    },
            //    new Schedule
            //    {
            //        ScheduleId = 2,
            //        StartTime = new DateTime(2024, 9, 11, 11, 0, 0),  // Example: September 11, 2024 at 11:00 AM
            //        EndTime = new DateTime(2024, 9, 11, 12, 0, 0),    // Example: September 11, 2024 at 12:00 PM
            //        MaxCapacity = 30,
            //        ClassId = 2,
            //        TeacherId = 2
            //    },
            //    new Schedule
            //    {
            //        ScheduleId = 3,
            //        StartTime = new DateTime(2024, 9, 12, 14, 0, 0),  // Example: September 12, 2024 at 02:00 PM
            //        EndTime = new DateTime(2024, 9, 12, 15, 0, 0),    // Example: September 12, 2024 at 03:00 PM
            //        MaxCapacity = 25,
            //        ClassId = 3,
            //        TeacherId = 3
            //    }
            //);
        }
    }
    
}
