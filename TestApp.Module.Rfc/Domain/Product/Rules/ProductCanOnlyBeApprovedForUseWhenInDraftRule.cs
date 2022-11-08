using System;
using System.Collections.Generic;
using System.Text;
using TestApp.BuildingBlocks.Domain;

namespace TestApp.Module.Rfc.Domain.Product.Rules
{
    internal class ProductCanOnlyBeApprovedForUseWhenInDraftRule : IBusinessRule
    {
        private readonly string _currentStatus;

        public ProductCanOnlyBeApprovedForUseWhenInDraftRule(string currentStatus)
        {
            _currentStatus = currentStatus;
        }

        public bool IsBroken()
        {
            return _currentStatus != "DRAFT";
        }

        public string Message => "Product can only be started when in draft";
    }
}
