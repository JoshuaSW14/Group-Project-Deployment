using Lab1_TeamMembershipSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_TeamMembershipSystem.ViewModels
{
    public class InvestmentsListViewModel
    {
        public IEnumerable<Interest> Interests { get; set; }
        public IEnumerable<Bucket> Buckets { get; set; }
    }
}
