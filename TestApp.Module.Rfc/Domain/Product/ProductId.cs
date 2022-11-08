using System;
using System.Collections.Generic;
using System.Text;
using TestApp.BuildingBlocks.Domain;

namespace TestApp.Module.Rfc.Domain.Product
{
    internal class ProductId : ValueObject<ProductId>
    {
        private readonly Guid _productTypeVersionUniqueId;

        protected ProductId(Guid productTypeVersionUniqueId)
        {
            _productTypeVersionUniqueId = productTypeVersionUniqueId;
        }

        public static ProductId For(Guid productId)
        {
            return new ProductId(productId);
        }

        protected override bool EqualsCore(ProductId other)
        {
            return other._productTypeVersionUniqueId == _productTypeVersionUniqueId;
        }

        protected override int GetHashCodeCore()
        {
            return _productTypeVersionUniqueId.GetHashCode();
        }
    }
}
