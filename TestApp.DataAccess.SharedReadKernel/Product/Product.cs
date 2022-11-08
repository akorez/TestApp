using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace IoCore.SharedReadKernel.Product
{
    public class Product
    {
        public Product(string title, string version, DateTime dateRaised, string status)
        {
            Title = title;
            Version = version;
            DateRaised = dateRaised;
            Status = status;
        }

        public Guid Id { get; private set; }

        public string Title { get; private set; }

        public string Version { get; private set; }

        public DateTime DateRaised { get; private set; }

        public string Status { get; private set; }
    }
}
