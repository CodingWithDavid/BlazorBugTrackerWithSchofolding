using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorBugTrackerWithSchofolding.Models;

namespace BlazorBugTrackerWithSchofolding.Data
{
    public class BlazorBugTrackerWithSchofoldingContext : DbContext
    {
        public BlazorBugTrackerWithSchofoldingContext (DbContextOptions<BlazorBugTrackerWithSchofoldingContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorBugTrackerWithSchofolding.Models.Bug> Bug { get; set; } = default!;
        public DbSet<BlazorBugTrackerWithSchofolding.Models.Defect> Defect { get; set; } = default!;
        public DbSet<BlazorBugTrackerWithSchofolding.Models.UserStory> UserStory { get; set; } = default!;
    }
}
