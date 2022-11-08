using FluentValidation;

namespace TestApp.Module.Rfc.Application.ApproveForUseProduct
{
    internal class ApproveForUseProductValidator :AbstractValidator<ApproveForUseProductCommand>
    {
        public ApproveForUseProductValidator()
        {
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("Product Id cannot be empty");
        }
    }
}
