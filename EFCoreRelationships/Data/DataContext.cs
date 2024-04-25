using EFCoreRelationships.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreRelationships.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Weapon> Weapons { get; set; }

        public DbSet<House> Houses { get; set; }
    }
}
