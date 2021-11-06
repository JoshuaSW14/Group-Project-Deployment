using System;
using System.Collections.Generic;
using System.Text;
using Lab1_TeamMembershipSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab1_TeamMembershipSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Bucket> Buckets { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<SportCategory> SportCategories { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<BucketTeamConnection> BucketTeamConnections { get; set; }
    }
}
