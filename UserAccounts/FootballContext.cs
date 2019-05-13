namespace UserAccounts
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using UserAccounts.Models;

    public class FootballContext : DbContext
    {

        public FootballContext()
            : base("name=DefaultConnection")
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

    }
}