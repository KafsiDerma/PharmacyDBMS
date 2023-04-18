using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace PharmacyDBMS.Data
{
    public class PharmacyContext : DbContext
    {


        // constructor to use config data from appsettings.json
        protected readonly IConfiguration Configuration;

        public PharmacyContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // connect
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("PharmacyDatabase"));
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // override to make dispenses have compsite primary key
            modelBuilder.Entity<Dispenses>().HasKey(e => new { e.CartID, e.ProductID , e.PharmacistID});


            modelBuilder.Entity<Employee>()
                .ToTable("Employee");

            modelBuilder.Entity<Employee>()
                .HasData(
                    new Employee
                    {
                        Id = 3440,
                        Name = "admin",
                        HashedPassword = BCrypt.Net.BCrypt.HashPassword("admin"),
                        Salary = 0,
                        PhoneNumber = "",
                        Position = 5,
                        
                    }
                );

          


            




        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Dispenses> Dispenses { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<InsuranceAgency> InsuranceAgencies { get;  set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<prescription_only> Prescriptions_only { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }


    }
}
