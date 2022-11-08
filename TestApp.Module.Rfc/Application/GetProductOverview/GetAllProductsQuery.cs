using System;
using System.Collections.Generic;
using System.Text;
using TestApp.BuildingBlocks.Application.Queries;

namespace TestApp.Module.Rfc.Application.GetProductOverview
{
   public record GetAllProductsQuery : IQuery<IEnumerable<ProductOverviewDto>>;

}
