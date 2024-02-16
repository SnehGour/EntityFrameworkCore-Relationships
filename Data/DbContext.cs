using Microsoft.EntityFrameworkCore;
using Test.EFcore.Models;

namespace Test.EFcore.Data
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<Data.DbContext> options) : base(options){ }
        
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
