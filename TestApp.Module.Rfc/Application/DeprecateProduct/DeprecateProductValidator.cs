using FluentValidation;

namespace TestApp.Module.Rfc.Application.DeprecateProduct
{
    internal class DeprecateProductValidator :AbstractValidator<DeprecateProductCommand>
    {
        public DeprecateProductValidator()
        {
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("Product Id cannot be empty");
        }
    }
}
