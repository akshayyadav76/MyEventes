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
    public class EventUserConfigration : IEntityTypeConfiguration<EventUser>
    {
        public void Configure(EntityTypeBuilder<EventUser> builder)
        {
            builder.HasKey(et => new { et.EventId, et.UserId });
            builder.HasOne<Event>()
                .WithMany().HasForeignKey(e => e.EventId);
            builder.HasOne<User>()
                .WithMany().HasForeignKey(e => e.UserId);
        }
    }
}
