using FluentValidation;

namespace TestApp.Module.Rfc.Application.DraftProduct
{
    internal class DraftProductValidator :AbstractValidator<DraftProductCommand>
    {
        public DraftProductValidator()
        {
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("Product Id cannot be empty");
        }
    }
}
