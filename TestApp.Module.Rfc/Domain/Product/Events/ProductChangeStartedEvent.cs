using System;
using System.Collections.Generic;
using System.Text;
using TestApp.BuildingBlocks.Domain;

namespace TestApp.Module.Rfc.Domain.Product.Events
{
    internal class ProductChangeStartedEvent : IDomainEvent
    {
        public string ProductTitle { get; }

        public ProductChangeStartedEvent(string productTitle)
        {
            ProductTitle = productTitle;
        }
    }
}
