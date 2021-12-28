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

            builder.HasData(
                new Location { Id = 1, Title = "Beerhall", Street = "Beerstreet", HouseNumber = "5A", PostalCode = "80135", CityName = "Munich" },
                new Location { Id = 2, Title = null, Street = "Beerstreet", HouseNumber = "10", PostalCode = "81035", CityName = "Munich" },
                new Location { Id = 3, Title = null, Street = "Gardenstreet", HouseNumber = "101", PostalCode = "80031", CityName = "Munich" },
                new Location { Id = 4, Title = "The Green One", Street = "Veggiestreet", HouseNumber = "12", PostalCode = "12141", CityName = "Berlin" },
                new Location { Id = 5, Title = null, Street = "Park Plaza", HouseNumber = "1", PostalCode = "11011", CityName = "Berlin" },
                new Location { Id = 6, Title = "Partyhouse", Street = "Carnevalstreet", HouseNumber = "3", PostalCode = "12345", CityName = "Cologne" },
                new Location { Id = 7, Title = null, Street = "Some", HouseNumber = "18", PostalCode = "72657", CityName = "Hamburg" });

        }
    }
}
