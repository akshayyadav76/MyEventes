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
    public class TagConfigration : IEntityTypeConfiguration<Tag>
    {

        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(c => c.TagName);
        }
    }
}
