using System;
using System.Collections.Generic;
using System.Text;
using TestApp.BuildingBlocks.Domain;

namespace TestApp.Module.Rfc.Domain.Product.Rules
{
    internal class ProductCanOnlyBeDraftedWhenInApprovedForUse : IBusinessRule
    {
        private readonly string _currentStatus;

        public ProductCanOnlyBeDraftedWhenInApprovedForUse(string currentStatus)
        {
            _currentStatus = currentStatus;
        }

        public bool IsBroken()
        {
            return _currentStatus != "APPROVEDFORUSE";
        }
        public string Message => "Product can only be drafted when in approved for use";
    }
}
