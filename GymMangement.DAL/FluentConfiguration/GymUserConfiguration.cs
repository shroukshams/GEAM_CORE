using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using GymMangement.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GymMangement.DAL.FluentConfiguration
{
    internal class GymUserConfiguration<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(X => X.Name)
                .HasMaxLength(50);
            builder.Property(X => X.Email).HasMaxLength(50);
            builder.HasIndex(X => X.Email).IsUnique();
            builder.HasIndex(X => X.phoneNumber).IsUnique();
            
            builder.ToTable( tb =>
            {
                tb.HasCheckConstraint("EmailCheck", "Email LIKE '_%@_%._%'");
                tb.HasCheckConstraint("phoneNumberCheck", "phoneNumber LIKE '010% OR 011% OR 012% OR 015%'");
            });

        }


    }
    }
    

