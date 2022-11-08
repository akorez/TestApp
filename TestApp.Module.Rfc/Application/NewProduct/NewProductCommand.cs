using TestApp.BuildingBlocks.Application.Commands;

namespace TestApp.Module.Rfc.Application.NewProduct
{
    public record NewProductCommand : ICommand
    {
        public string Title { get; set; }
        public string Version { get; set; }
    }

}
