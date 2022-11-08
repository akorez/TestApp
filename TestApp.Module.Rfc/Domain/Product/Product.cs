using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;
using TestApp.BuildingBlocks.Domain;
using TestApp.Module.Rfc.Domain.Product.Events;
using TestApp.Module.Rfc.Domain.Product.Rules;

namespace TestApp.Module.Rfc.Domain.Product
{
    internal class Product : Entity, IAggregateRoot
    {
        private const string Drafted = "DRAFT";
        private const string ApprovedForUse = "APPROVEDFORUSE";
        private const string Deprecated = "DEPRECATED";

        public string Title { get; }
        public string Version { get; }
        public DateTime DateRaised { get; }
        public string Status { get; private set; }

        private Product(
            string title,
            string version,
            DateTime dateRaised)
        {
            Title = title;
            Version = version;
            DateRaised = dateRaised;
            Status = Drafted;
        }


        public static Product Create(string title, string version)
        {
            CheckRule(new ProductRequiresTitleRule(title));
            CheckRule(new ProductRequiresVersionRule(version));

            var product = new Product
            (
                title,
                version,
                dateRaised: DateTime.UtcNow

            );

            return product;
        }

        public void Start()
        {
            CheckRule(new ProductCanOnlyBeStartedWhenInDraftRule(Status));

            Status = Drafted;

            AddDomainEvent(new ProductChangeStartedEvent(Title));

        }

        public void ApproveForUse()
        {
            CheckRule(new ProductCanOnlyBeApprovedForUseWhenInDraftRule(Status));

            Status = ApprovedForUse;

            AddDomainEvent(new ProductChangeApprovedForUseEvent(Title));

        }

        public void Deprecate()
        {
            CheckRule(new ProductCanOnlyBeDeprecatedWhenInApprovedForUse(Status));

            Status = Deprecated;

            AddDomainEvent(new ProductChangeDeprecatedEvent(Title));
        }

        public void Draft()
        {
            CheckRule(new ProductCanOnlyBeDraftedWhenInApprovedForUse(Status));

            Status = Drafted;

            AddDomainEvent(new ProductChangeDraftedEvent(Title));
        }

    }
}
