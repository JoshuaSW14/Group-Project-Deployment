﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab1_TeamMembershipSystem.Models
{
    public class Team
    {
        [Key]
        public Guid Id { get; set; }

        public String Name { get; set; }

        public String Description { get; set; }

        [Display(Name = "Sport Category")]
        public SportCategory SportCategory { get; set; }

        public League League { get; set; }

        [ForeignKey("SportCategory")]
        public Guid SportCategoryFK { get; set; }

        [ForeignKey("League")]
        public Guid LeagueFK { get; set; }

        public ICollection<BucketTeamConnection> BucketTeamConnections { get; set; }

        public ICollection<Interest> Interests { get; set; }
    }
}
