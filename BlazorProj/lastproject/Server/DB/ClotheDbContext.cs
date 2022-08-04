using Microsoft.EntityFrameworkCore;
using lastproject.Server.Controllers;
using lastproject.Shared.Models;

namespace lastproject.Server.DB
{
    public class ClotheDbContext : DbContext
    {
        public ClotheDbContext(DbContextOptions<ClotheDbContext> options)
            : base(options)
        {}

        public DbSet<Clothe> Clothes { get; set; }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}