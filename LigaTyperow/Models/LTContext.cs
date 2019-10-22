using Microsoft.EntityFrameworkCore;

namespace LigaTyperow.Models
{
    public class LTContext : DbContext
    {
        public DbSet<Match> Matches { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Footballer> Footballers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("Data Source=lt.db");
    }
}