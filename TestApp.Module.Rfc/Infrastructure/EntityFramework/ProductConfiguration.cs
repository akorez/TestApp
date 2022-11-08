using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TestApp.BuildingBlocks.Infrastructure.Domain.EntityFramework;
using TestApp.Module.Rfc.Domain.Product;

namespace TestApp.Module.Rfc.Infrastructure.EntityFramework
{
    internal class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        protected override void ConfigureCore(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasAlternateKey(product => product.Title);
            builder.Property(product => product.Version).IsRequired();
            builder.Property(product => product.DateRaised).IsRequired();
            builder.Property(product => product.Status).IsRequired();
        }
    }
}
