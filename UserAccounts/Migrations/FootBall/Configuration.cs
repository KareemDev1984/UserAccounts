namespace UserAccounts.Migrations.FootBall
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UserAccounts.Data;

    internal sealed class Configuration : DbMigrationsConfiguration<UserAccounts.FootballContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\FootBall";
        }

        protected override void Seed(UserAccounts.FootballContext context)
        {
            foreach (var item in DummyData.GetTeams())
            {
                context.Teams.AddOrUpdate(item);
            }
            context.SaveChanges();

            foreach (var item in DummyData.GetPlayers(context))
            {
                context.Players.AddOrUpdate(item);
            }
            context.SaveChanges();
        }
    }
}
