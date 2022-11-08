using Microsoft.AspNetCore.Mvc;
using TestApp.Module.Rfc.Application.ApproveForUseProduct;
using TestApp.Module.Rfc.Application.DeprecateProduct;
using TestApp.Module.Rfc.Application.DraftProduct;
using TestApp.Module.Rfc.Application.GetProductOverview;
using TestApp.Module.Rfc.Application.NewProduct;
using TestApp.ModuleIntegration.EntryPoint;

namespace TestApp.Api.Business.Product
{
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("/products")]
        public async Task<IEnumerable<ProductOverviewDto>> GetAllProducts([FromServices] IModuleDispatcher moduleDispatcher)
        {
            var query = new GetAllProductsQuery();
            var allProducts = await moduleDispatcher.Execute(query);

            return allProducts;
        }

        [HttpPost("/product/")]
        public async Task NewProduct(NewProductCommand command, [FromServices] IModuleDispatcher moduleDispatcher)
        {
            await moduleDispatcher.Execute(command);
        }

        [HttpPost("/product/approve-for-use")]
        public async Task ApprovedForUseProduct(ApproveForUseProductCommand command, [FromServices] IModuleDispatcher moduleDispatcher)
        {
            await moduleDispatcher.Execute(command);
        }

        [HttpPost("/product/deprecate")]
        public async Task DeprecateProduct(DeprecateProductCommand command, [FromServices] IModuleDispatcher moduleDispatcher)
        {
            await moduleDispatcher.Execute(command);
        }

        [HttpPost("/product/draft")]
        public async Task DraftProduct(DraftProductCommand command, [FromServices] IModuleDispatcher moduleDispatcher)
        {
            await moduleDispatcher.Execute(command);
        }

    }
}
