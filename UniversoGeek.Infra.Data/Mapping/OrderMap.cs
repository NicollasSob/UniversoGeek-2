﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversoGeek.Domain.Entities;
using UniversoGeek.Domain.Shared.Parameters;

namespace UniversoGeek.Infra.Data.Mapping
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable(TableNames.TbOrder);
            builder.Property(o => o.ClientId).IsRequired();
            builder.Property(o => o.TotalValue).HasPrecision(10, 2);
            builder.Property(o => o.Discount).HasPrecision(10, 2);

            builder.Ignore(o => o.Deleted);
        }
    }
}
