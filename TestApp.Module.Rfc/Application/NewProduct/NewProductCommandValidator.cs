using FluentValidation;
using TestApp.BuildingBlocks.Application.Commands;

namespace TestApp.Module.Rfc.Application.NewProduct
{
    internal class NewProductCommandValidator : CommandValidatorBase<NewProductCommand>
    {
        public NewProductCommandValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Product Title cannot be empty");
            RuleFor(x => x.Version).NotEmpty().WithMessage("Product Version cannot be empty");
        }
    }
}
