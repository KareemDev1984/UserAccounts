using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserAccounts.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string Position { get; set; }
        [DisplayName("Team Name")]
        public string TeamName { get; set; }
        public Team Team { get; set; }
        public bool IsActive { get; set; }
    }
}