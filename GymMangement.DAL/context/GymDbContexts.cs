using GEAM_CORE.FluentConfiguration;
using GEAM_CORE.Models;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace GEAM_CORE.context
{
    public class GymDbContexts: DbContext
    {
       public GymDbContexts(DbContextOptions<GymDbContexts> options) 
        :base(options)
        { 
        
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Plan>(new plansConfiguration());
        }

        public DbSet<Models.Plan> Plans { get; set; }
        

    }
}
