using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GymMangement.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GymMangement.DAL.FluentConfiguration
{
    internal class MemberConfiguration : GymUserConfiguration<Models.Member>, IEntityTypeConfiguration<Models.Member> { 
    
        public new void configuer(EntityTypeBuilder<Member> builder)
        {
            builder.Property(X => X.createdAt).HasColumnName("JionDate").HasDefaultValueSql("GETDARE()");
            base.Configure(builder);
        }
    }
    
    
    
    }
    

