using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserAccounts.Models;

namespace UserAccounts.Data
{
    public static class DummyData
    {
        public static List<Team> GetTeams()
        {

            List<Team> teams = new List<Team>()
            {
            new Team(){  TeamName = "RSCA", City = "Brussel", Province = "Brussel"  },
            new Team(){  TeamName = "Gent", City = "Gent", Province = "Oost-vlaanderen"  },
            new Team(){  TeamName = "Brugge", City = "Brugge", Province = "West-Vlaanderen"  },
            new Team(){  TeamName = "Antwerp", City = "Antwerpen", Province = "Antwerpe"  },

            };
            return teams;

        }

        public static List<Player> GetPlayers(FootballContext context)
        {

            List<Player> players = new List<Player>()
            {
            new Player(){  FirstName="Ronaldo", LastName="Ronaldo", Position="Aanvaller",TeamName = context.Teams.Find("RSCA").TeamName},
            new Player(){  FirstName="Karim", LastName="Lamrini", Position="Aanvaller",TeamName = context.Teams.Find("Antwerp").TeamName},
            new Player(){  FirstName="Eden", LastName="Hazard", Position="Keeper",TeamName = context.Teams.Find("Brugge").TeamName},

            };
            return players;

        }


    }
}