using Microsoft.EntityFrameworkCore;
using ProjectApi.Models;

namespace ProjectApi.DataContext
{

    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<User> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            #region BlogSeed
           
            modelBuilder.Entity<User>().HasData(
                (new User { ID = 1, LastName = "Robert", FirstName = "John", Address = "Address", Age = 30 , Intrests = "Singing"  }),
            (new User { ID = 2, LastName = "Dennis", FirstName = "Richard", Address = "Address", Age = 40, Intrests = "Browsing" }),
             (new User { ID = 3, LastName = "Joe", FirstName = "Richard", Address = "Address", Age = 44, Intrests = "Rafting" })
                );
            #endregion
        }
    }
}
