using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversoGeek.Domain.Entities;
using UniversoGeek.Domain.Shared.Parameters;

namespace UniversoGeek.Infra.Data.Mapping
{
       public class CategoryMap : IEntityTypeConfiguration<Category>
        {
            public void Configure(EntityTypeBuilder<Category> builder)
            {
                builder.ToTable(TableNames.TbCategory);
                builder.Property(p => p.Name).HasMaxLength(100).IsRequired();
                builder.Property(p => p.Description).HasMaxLength(240);
                builder.Property(p => p.Active).HasDefaultValue(true);
                builder.Ignore(p => p.Deleted);
            }
        }
    
}
