using System;
using System.Collections.Generic;
using System.Text;
using TestApp.BuildingBlocks.Domain;

namespace TestApp.Module.Rfc.Domain.Product.Rules
{
    internal class ProductCanOnlyBeStartedWhenInDraftRule : IBusinessRule
    {
        private readonly string _currentStatus;

        public ProductCanOnlyBeStartedWhenInDraftRule(string currentStatus)
        {
            _currentStatus = currentStatus;
        }

        public bool IsBroken()
        {
            return _currentStatus != "DRAFT";
        }


        public string Message => "Request for change can only be started when in draft";
    }
}
