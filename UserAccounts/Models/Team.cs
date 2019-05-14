using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserAccounts.Models
{
    public class Team
    {
        [Key]
        [MaxLength(30)]
        [DisplayName("Team Name")]
        public string TeamName { get; set; }
        public string City { get; set; }
        public string Province { get; set; }

        ICollection<Player> players;

        public Team()
        {
            players = new List<Player>();
        }

    }
}