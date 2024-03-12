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
                    categoryCustomers = "Golden",
                    FirstName ="Yasin",
                    LastName="ValiPour"
                },
                new Person
                {
                    Id = 2,
                    categoryCustomers = "Golden",
                    FirstName = "Ali",
                    LastName = "Hafezi"
                },
                new Person
                {
                    Id = 3,
                    categoryCustomers = "Golden",
                    FirstName = "MohammadReza",
                    LastName = "Sohrablo"
                },
                new Person
                {
                    Id = 4,
                    categoryCustomers = "Golden",
                    FirstName = "Ali",
                    LastName = "Hasani"
                },
                new Person
                {
                    Id = 5,
                    categoryCustomers = "Bronze",
                    FirstName = "Radin",
                    LastName = "Mahfozian"
                },
                new Person
                {
                    Id = 6,
                    categoryCustomers = "Bronze",
                    FirstName = "Parsa",
                    LastName = "Mohammadi"
                },
                new Person
                {
                    Id = 7,
                    categoryCustomers = "Simple",
                    FirstName = "Parsa",
                    LastName = "Khezli"
                },
                new Person
                {
                    Id = 8,
                    categoryCustomers = "Simple",
                    FirstName = "Nima",
                    LastName = "tarhani"
                },
                new Person
                {
                    Id = 9,
                    categoryCustomers = "Simple",
                    FirstName = "Ali",
                    LastName = "Mashhadi"
                },
                new Person
                {
                    Id = 10,
                    categoryCustomers = "Simple",
                    FirstName = "Omid",
                    LastName = "Asadi"
                }
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
