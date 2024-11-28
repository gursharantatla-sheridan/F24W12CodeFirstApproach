using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24W12CodeFirstApproach
{
    // context class
    // a class that inherits from built-in DbContext class
    public class SchoolContext : DbContext
    {
        // entity sets - (required)
        // define entity properties of type DbSet<>
        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }


        // database connection - (required)
        // define the connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=SchoolCF2; Trusted_Connection=True;MultipleActiveResultSets=true;");
        }


        // data seeding - (optional)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Standard>().HasData(
                new Standard() { StandardId = 1, StandardName = "Standard 1" },
                new Standard() { StandardId = 2, StandardName = "Standard 2" },
                new Standard() { StandardId = 3, StandardName = "Standard 3" }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student() { StudentId = 1, Name = "John", StandardId = 1 },
                new Student() { StudentId = 2, Name = "Anne", StandardId = 1 },
                new Student() { StudentId = 3, Name = "Mark", StandardId = 2 }
            );
        }
    }
}
