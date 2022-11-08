using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TestApp.Module.Rfc.Domain.Product;

namespace TestApp.Module.Rfc.Infrastructure.EntityFramework
{
    internal class ProductRepository : IProductRepository
    {
        private readonly RequestForChangeContext _dbContext;

        public ProductRepository(RequestForChangeContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Product product)
        {
            await _dbContext.Products.AddAsync(product);

            await _dbContext.SaveChangesAsync();
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            var product = await _dbContext.Products.FindAsync(id);

            return product;
        }
    }
}
