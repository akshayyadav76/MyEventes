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
        }
    }
}
