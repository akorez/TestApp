using System;
using System.Collections.Generic;
using System.Text;
using TestApp.BuildingBlocks.Domain;

namespace TestApp.Module.Rfc.Domain.Product.Rules
{
    internal class ProductCanOnlyBeDeprecatedWhenInApprovedForUse : IBusinessRule
    {
        private readonly string _currentStatus;

        public ProductCanOnlyBeDeprecatedWhenInApprovedForUse(string currentStatus)
        {
            _currentStatus = currentStatus;
        }

        public bool IsBroken()
        {
            return _currentStatus != "APPROVEDFORUSE";
        }

        public string Message => "Product can only be deprecated when in approved for use";
    }
}
