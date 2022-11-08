using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TestApp.Module.Rfc.Application.WithdrawRfc;

namespace TestApp.Module.Rfc.Application.CompleteRfc
{
    internal class CompleteRfcCommandValidator : AbstractValidator<WithdrawRfcCommand>
    {
        public CompleteRfcCommandValidator()
        {
            RuleFor(x => x.RfcId).NotEmpty().WithMessage("Rfc Id cannot be empty");
        }
    }
}
