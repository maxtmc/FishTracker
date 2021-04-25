using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FishTracker.Models
{
    public class FishTrackerContext : DbContext
    {
        public FishTrackerContext (DbContextOptions<FishTrackerContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<FishTracker.Models.Catch> Catch { get; set; }
    }
}
