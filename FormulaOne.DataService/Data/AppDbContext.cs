using FormulaOne.Entities.DbSet;
using Microsoft.EntityFrameworkCore;

namespace FormulaOne.DataService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public virtual DbSet<Driver> Drives { get; set; }
        public virtual DbSet<Achievement> Achievements { get; set; }
    }
}
