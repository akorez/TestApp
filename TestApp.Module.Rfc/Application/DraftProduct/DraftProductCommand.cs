using System;
using TestApp.BuildingBlocks.Application.Commands;

namespace TestApp.Module.Rfc.Application.DraftProduct
{
    public record DraftProductCommand(Guid ProductId) : ICommand
    {
        public Guid ProductId { get; } = ProductId;
    }
}
