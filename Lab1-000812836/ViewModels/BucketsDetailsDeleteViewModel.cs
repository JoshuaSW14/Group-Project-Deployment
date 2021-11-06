using Lab1_TeamMembershipSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_TeamMembershipSystem.ViewModels
{
    public class BucketsDetailsDeleteViewModel
    {
        public Bucket Bucket { get; set; }
        public List<Team> Teams { get; set; }
    }
}
