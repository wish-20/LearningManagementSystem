using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMS.Data
{
    public class SystemDbContext:DbContext
    {
        public SystemDbContext(DbContextOptions<SystemDbContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<>()
        }
        public DbSet<Course>courses {  get; set; }
        public DbSet<Instructer> Instructer { get; set; }

        public DbSet<Progress> Progress { get; set; }
        public DbSet<Enrollment> Enrollment { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<Module> Module { get; set; }
        public DbSet<Review> Review { get; set; }





    }
}
