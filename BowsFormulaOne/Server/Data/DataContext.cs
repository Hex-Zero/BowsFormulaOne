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
                new UserDto { Id = 1, FirstName = "Maxwell", LastName = "Archer", EmployeeNumber = "Es553"},
                new UserDto { Id = 2, FirstName = "Alexandra", LastName = "Archer", EmployeeNumber = "r7jTG8dqBy5wGO4L"}
            );

            modelBuilder.Entity<PhoneNumberDto>().HasData(
                new PhoneNumberDto { Id = 1, UserDtoId = 1, PhoneNumber = "07667587200" },
                new PhoneNumberDto { Id = 3, UserDtoId = 1, PhoneNumber = "07667986200" },
                new PhoneNumberDto { Id = 4, UserDtoId = 1, PhoneNumber = "07667987206" },
                new PhoneNumberDto { Id = 2, UserDtoId = 2, PhoneNumber = "07662987201" }
            );

            modelBuilder.Entity<EmailDto>().HasData(
                new EmailDto{ Id = 1, UserDtoId = 1, EmailAddress = "Hex@live.com"},
                new EmailDto{ Id = 3, UserDtoId = 1, EmailAddress = "Hexzero@gmail.com"},
                new EmailDto{ Id = 4, UserDtoId = 1, EmailAddress = "Hex@live.co.uk"},
                new EmailDto{ Id = 2, UserDtoId = 2, EmailAddress = "Alex@gmail.com"}
            );

            modelBuilder.Entity<CardDto>().HasData(
                new CardDto{ Id = 1, UserDtoId = 1, CardNumber = "r7jTG8dqBy5wGO4L", PinCode = "1000", Balance = 10},
                new CardDto{ Id = 2, UserDtoId = 2, CardNumber = "r7jTG83qBy5wGO4L", PinCode = "1200", Balance = 20}
            );
        }

        public DbSet<UserDto> Users { get; set; }
        public DbSet<PhoneNumberDto> PhoneNumbers { get; set; }
        public DbSet<EmailDto> Emails { get; set; }
        public DbSet<CardDto> CardDto { get; set; }
    }
}
