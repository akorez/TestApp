using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestApp.BuildingBlocks.Application;
using TestApp.BuildingBlocks.Application.Commands;
using TestApp.Module.Rfc.Domain.Product;

namespace TestApp.Module.Rfc.Application.ApproveForUseProduct
{
    internal class ApproveForUseProductCommandHandler : ICommandHandler<ApproveForUseProductCommand>
    {
        private readonly IProductRepository _repository;

        public ApproveForUseProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(ApproveForUseProductCommand command, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(command.ProductId);

            if (product == null) throw new NotFoundException("Product not found");

            product.ApproveForUse();

            await _repository.CommitAsync();

            return Unit.Value;

        }
    }
}
