using System;
using System.Collections.Generic;
using System.Text;
using TestApp.BuildingBlocks.Application.Commands;

namespace TestApp.Module.Rfc.Application.CompleteRfc
{
    public record CompleteRfcCommand(Guid RfcId) : ICommand
    {
        public Guid RfcId { get; } = RfcId;
    }
}
