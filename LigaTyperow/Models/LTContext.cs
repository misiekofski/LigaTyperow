using LigaTyperow.Models.League;
using LigaTyperow.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace LigaTyperow.Models
{
    public class LTContext : DbContext
    {
        public DbSet<Match> Matches { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Footballer> Footballers { get; set; }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("Data Source=lt.db");
    }
}