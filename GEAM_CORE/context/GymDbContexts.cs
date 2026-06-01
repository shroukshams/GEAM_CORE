using GEAM_CORE.FluentConfiguration;
using GEAM_CORE.Models;
using Microsoft.EntityFrameworkCore;
namespace GEAM_CORE.context
{
    public class GymDbContexts: DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Appseting.Json
            optionsBuilder.UseSqlServer("Server=.;Database=Gym;Trusted_Connection=true;TrustServerCertificate=True;");
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Plan>(new plansConfiguration());
        }

        public DbSet<Models.Plan> Plans { get; set; }
    }
}
