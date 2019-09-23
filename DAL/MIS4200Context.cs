using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using rp799815_MIS4200.Models; // This is needed to access the models
using System.Data.Entity; // This is needed to access the DbContext Object

namespace rp799815_MIS4200.DAL
{
    public class MIS4200Context : DbContext // inherits from DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {
            // add the Set Initializer statement here
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, rp799815_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}