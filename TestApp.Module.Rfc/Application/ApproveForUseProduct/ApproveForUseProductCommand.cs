using System;
using TestApp.BuildingBlocks.Application.Commands;

namespace TestApp.Module.Rfc.Application.ApproveForUseProduct
{
    public record ApproveForUseProductCommand(Guid ProductId) : ICommand
    {
        public Guid ProductId { get; } = ProductId;
    }
}
