using EFcore.RelationShips.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.RelationShips.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }

        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
    }
}
