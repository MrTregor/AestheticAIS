using Microsoft.EntityFrameworkCore;

namespace AestheticService.Models
{
    public class MobileContext: DbContext
    {
        public DbSet<goods> Goods { get; set; }
        public DbSet<goods_oborot> Goods_oborot { get; set; }
        public DbSet<preyskurant> Preyskurant { get; set; }
        public DbSet<priems> Priems { get; set; }

        public MobileContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Filename=..\..\aesthetic.db");
        }
    }
}