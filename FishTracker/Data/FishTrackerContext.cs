using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FishTracker.Models;

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

        public DbSet<FishTracker.Models.Weather> Weather { get; set; }

        public DbSet<FishTracker.Models.Image> Image { get; set; }

        public DbSet<FishTracker.Models.Water> Water { get; set; }
    }
}
