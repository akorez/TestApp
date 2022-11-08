using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestApp.BuildingBlocks.Domain;

namespace TestApp.Module.Rfc.Domain.Product
{
    internal interface IProductRepository : IRepository<Product>
    {
        Task CommitAsync();
    }
}
