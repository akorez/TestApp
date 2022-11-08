using System;
using System.Collections.Generic;
using System.Text;
using TestApp.BuildingBlocks.Domain;

namespace TestApp.Module.Rfc.Domain.Product.Events
{
    internal class ProductChangeDraftedEvent :IDomainEvent
    {
        public string ProductTitle { get; }

        public ProductChangeDraftedEvent(string productTitle)
        {
            ProductTitle = productTitle;
        }
    }
}
