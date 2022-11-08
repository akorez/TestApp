using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TestApp.BuildingBlocks.Application.Commands;
using TestApp.Module.Rfc.Domain.Product;

namespace TestApp.Module.Rfc.Application.NewProduct
{
    internal class NewProductCommandHandler : ICommandHandler<NewProductCommand>
    {
        private readonly IProductRepository _repository;

        public NewProductCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(NewProductCommand command, CancellationToken cancellationToken)
        {
            var product = Domain.Product.Product.Create( command.Title!,command.Version!);

            product.Start();

            await _repository.AddAsync(product);

            return Unit.Value;
        }
    }
}
