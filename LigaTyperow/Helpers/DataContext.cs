using LigaTyperow.Entities;
using LigaTyperow.Models.League;
using Microsoft.EntityFrameworkCore;

namespace LigaTyperow.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Match> Matches { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Footballer> Footballers { get; set; }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<User> Users { get; set; }

    }
}