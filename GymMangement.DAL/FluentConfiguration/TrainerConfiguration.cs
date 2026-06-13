using GymMangement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement.DAL.FluentConfiguration
{

    internal class TrainerConfiguration : GymUserConfiguration<Models.trainer>, IEntityTypeConfiguration<Models.trainer>
    {

        public new void configuer(EntityTypeBuilder<trainer> builder)
        {
            builder.Property(X => X.createdAt).HasColumnName("HireDAte").HasDefaultValueSql("GETDARE()");
            base.Configure(builder);
        }
    }

}

    

