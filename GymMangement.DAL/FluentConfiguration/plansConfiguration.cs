using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GEAM_CORE.FluentConfiguration;
    using GEAM_CORE.Models;
using Microsoft.EntityFrameworkCore;
    public class plansConfiguration : IEntityTypeConfiguration<Plan>
{

        public void Configure(EntityTypeBuilder<Models.Plan> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).HasMaxLength(200);
            builder.Property(p => p.Price).HasColumnType("decimal(18,2)");
           
            builder.Property(p => p.IsActive).IsRequired();
            builder.Property(p => p.CreatedAt).HasDefaultValueSql("GETDATE()");
            builder.Property(p => p.UpdatedAt).HasDefaultValueSql("GETDATE()");
        builder.ToTable(TB => { TB.HasCheckConstraint("PLanDurationCheck", "DurationOnDays Between 1 and 356"); });
    }
    }

