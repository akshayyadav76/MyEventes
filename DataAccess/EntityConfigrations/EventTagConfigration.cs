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
    public class EventTagConfigration : IEntityTypeConfiguration<EventTag>
    {
        public void Configure(EntityTypeBuilder<EventTag> builder)
        {
            builder.HasKey(et => new {  et.EventId, et.TagId });
            builder.HasOne<Event>()
                .WithMany().HasForeignKey(e => e.EventId);
            builder.HasOne<Tag>()
                .WithMany().HasForeignKey(e => e.TagId);

            builder.HasData(
                  new EventTag {Id =1, EventId = 1, TagId = "socialize" },
                  new EventTag {Id =2, EventId = 1, TagId = "connect" },
                  new EventTag {Id =3, EventId = 1, TagId = "dinner" });
        }
    }
}
