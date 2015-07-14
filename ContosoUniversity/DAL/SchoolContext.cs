using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {

        public SchoolContext() : base("SchoolContext")//This is the constructor and it is being passed explicitly pass in the name of the connection string Entity Framework assumes that the connection string name is the same as the class name. In this case, that is true, anyway.
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)//This method prevents the table names from being plauralized.
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

//Pick up in the tutorial at 'Set up EF to initialize the database with test data'---07/13/2015---11:03pm