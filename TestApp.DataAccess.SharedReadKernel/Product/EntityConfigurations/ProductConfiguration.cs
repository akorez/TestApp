using IoCore.SharedReadKernel.Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoCore.SharedReadKernel.Product.EntityConfigurations
{
    internal class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        protected override void ConfigureCore(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products", "rfc");
        }
    }
}
