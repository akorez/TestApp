using System;
using System.Collections.Generic;
using System.Text;
using TestApp.BuildingBlocks.Domain;

namespace TestApp.Module.Rfc.Domain.Product.Events
{
    internal class ProductChangeDeprecatedEvent :IDomainEvent
    {
        public string ProductTitle { get; }

        public ProductChangeDeprecatedEvent(string productTitle)
        {
            ProductTitle = productTitle;
        }
    }
}
