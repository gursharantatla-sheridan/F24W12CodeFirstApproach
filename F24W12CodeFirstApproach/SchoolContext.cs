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
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB;Database=SchoolCF; Trusted_Connection=True;MultipleActiveResultSets=true;");
        }


        // data seeding - {optional)

    }
}
