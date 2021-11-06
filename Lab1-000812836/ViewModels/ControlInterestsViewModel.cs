using Lab1_TeamMembershipSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_TeamMembershipSystem.ViewModels
{
    public class ControlInterestsViewModel
    {
        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<Interest> Interests { get; set; }
        public IEnumerable<League> Leagues { get; set; }
        public IEnumerable<Guid> InterestedTeamsIds { get; set; }
    }
}
