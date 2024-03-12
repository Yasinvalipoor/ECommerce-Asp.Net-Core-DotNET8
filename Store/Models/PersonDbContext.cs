using Microsoft.EntityFrameworkCore;

namespace Store.Models
{
    public class PersonDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public PersonDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person
                {
                    Id = 1,
                    FirstName="Yasin",
                    LastName="ValiPour"
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Ali",
                    LastName = "Hafezi"
                },
                new Person
                {
                    Id = 3,
                    FirstName = "MohammadReza",
                    LastName = "Sohrablo"
                },
                new Person
                {
                    Id = 4,
                    FirstName = "Ali",
                    LastName = "Hasani"
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
