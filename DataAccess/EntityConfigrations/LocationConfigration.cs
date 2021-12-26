using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigrations
{
    public class LocationConfigration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasKey(l =>l.Id);
            builder.Property(l => l.Title).IsRequired(false).IsUnicode(false).HasMaxLength(200);
            builder.Property(l => l.Street).IsRequired(false).IsUnicode(false).HasMaxLength(200);
            builder.Property(l => l.HouseNumber).IsRequired(true).IsUnicode(false).HasMaxLength(50);
            builder.Property(l => l.PostalCode).IsRequired(true).IsUnicode(false).HasMaxLength(10);

            builder.HasOne<City>()
            .WithMany()
            .HasForeignKey(l => l.CityName);
        }
    }
}
