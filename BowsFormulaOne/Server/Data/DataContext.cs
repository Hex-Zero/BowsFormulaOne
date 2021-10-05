using BowsFormulaOneAPI.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BowsFormulaOneAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserDto>().HasData(
                new UserDto { Id = 1, FirstName = "Maxwell", LastName = "Archer", EmployeeNumber = "r7jTG7dqBy5wGO4L"},
                new UserDto { Id = 2, FirstName = "Alexandra", LastName = "Archer", EmployeeNumber = "r7jTG8dqBy5wGO4L"}
            );
            modelBuilder.Entity<PhoneNumberDto>().HasData(
                new PhoneNumberDto{ Id = 1, UserDtoId = 1, PhoneNumber = "07767987200"},
                new PhoneNumberDto{ Id = 3, UserDtoId = 1, PhoneNumber = "07767986200"},
                new PhoneNumberDto{ Id = 4, UserDtoId = 1, PhoneNumber = "07767987206"},
                new PhoneNumberDto{ Id = 2, UserDtoId = 2, PhoneNumber = "07767987201"}
            );
        }

        public DbSet<UserDto> Users { get; set; }
        public DbSet<PhoneNumberDto> PhoneNumbers { get; set; }
    }
}
