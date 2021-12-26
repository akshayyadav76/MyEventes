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
    public class OrganizerConfigration : IEntityTypeConfiguration<Organizer>
    {

        public void Configure(EntityTypeBuilder<Organizer> builder)
        {
            builder.HasKey(o => o.UserId);
            builder.HasOne<User>().WithOne().HasForeignKey<Organizer>(e=>e.UserId);
            builder.Property(o => o.Passward).IsUnicode(false).IsRequired(true).HasMaxLength(50);
        }
    }
}
