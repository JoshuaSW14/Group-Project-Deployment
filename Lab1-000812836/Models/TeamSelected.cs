﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_TeamMembershipSystem.Models
{
    public class TeamSelected
    {
        public Guid Id { get; set; }
        public Team Team { get; set; }
        public bool Selected { get; set; }
    }
}
