using GymMangement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement.DAL.FluentConfiguration
{
    internal class SessiosConfiguration : IEntityTypeConfiguration<Session>

    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.ToTable(TB =>
            {
                TB.HasCheckConstraint("SessionCapacityCheck", "Capacity Between 1and 25");
                TB.HasCheckConstraint("SessionEndDATECheck", "EndDate >StartDate");
            });
        }
    }
}
