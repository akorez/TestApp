using System;
using System.Collections.Generic;
using System.Text;
using TestApp.BuildingBlocks.Domain;

namespace TestApp.Module.Rfc.Domain.Product.Events
{
    internal class ProductChangeApprovedForUseEvent :IDomainEvent
    {
        public string ProductTitle { get; }

        public ProductChangeApprovedForUseEvent(string productTitle)
        {
            ProductTitle = productTitle;
        }
    }
}
