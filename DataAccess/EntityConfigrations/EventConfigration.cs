using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfigrations
{
    public class EventConfigration : IEntityTypeConfiguration<Event>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e =>e.Id);
            builder.Property(m => m.Name)
               .IsUnicode(true)
               .HasMaxLength(100);

            builder.Property(e => e.Image).IsRequired(false).IsUnicode(false).HasMaxLength(200);
            builder.Property(e => e.Description).IsRequired(true).IsUnicode(true);

            builder.HasOne<Location>()
                .WithMany()
                .HasForeignKey(e => e.LocationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Organizer>()
               .WithMany()
               .HasForeignKey(e => e.OrganizerId)
               .OnDelete(DeleteBehavior.NoAction);


            builder.HasData(
                new Event { 
                    Id =1,
                    Name = "New in town",
                    DatePlanned = new DateTime(2022 ,02, 01, 17,30,00),
                    Image ="path/to/image.jpg",
                    Description =
                    "You are new in town? Join us and meet like-minded new people!",
                   MaxParticipants = 20,
                   MinAge= 16,
                  LocationId  =1,
                   OrganizerId= 1 }) ;
            

        }
    }
}
