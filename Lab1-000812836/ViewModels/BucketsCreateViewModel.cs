using Lab1_TeamMembershipSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_TeamMembershipSystem.ViewModels
{
    public class BucketsCreateViewModel
    {
        public Bucket Bucket { get; set; }
        public List<TeamSelected> TeamSelections { get; set; }
    }
}
