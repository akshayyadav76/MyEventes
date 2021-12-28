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
    public class UserConfigration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasKey(u => u.Id);
            builder.Property(u => u.FirstName).IsRequired(true).IsUnicode(false).HasMaxLength(200);
            builder.Property(u => u.LastName).IsRequired(true).IsUnicode(false).HasMaxLength(200);
            builder.Property(u => u.Birthdate).IsRequired(true).HasPrecision(3);
            builder.Property(u => u.Email).IsRequired(true).IsUnicode(false).HasMaxLength(200);

            builder.HasData(
                new User { Id = 1, FirstName = "Max", LastName = "Schwarz", Birthdate = new DateTime(1989, 05, 01), Email = "max@test.com" },
                new User { Id = 2, FirstName = "Manuel", LastName = "Lorenz", Birthdate = new DateTime(1988, 10, 19), Email = "manuel@test.com" },
                new User { Id = 3, FirstName = "Julie", LastName = "Barnes", Birthdate = new DateTime(1986, 02, 13), Email = "julie@test.com" },
                new User { Id = 4, FirstName = "Michael", LastName = "Smith", Birthdate = new DateTime(1982, 11, 11), Email = "michael@test.com" });
        }
    }
}
