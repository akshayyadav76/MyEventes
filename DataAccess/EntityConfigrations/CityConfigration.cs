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
    public class CityConfigration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(c => c.Name);

            builder.HasData(
                new City {Name= "Munich" },
                new City { Name = "Berlin" },
                new City { Name = "Cologne" },
                new City { Name = "Frankfurt" },
                new City { Name = "Hamburg" }
                );
        }
    }
}
