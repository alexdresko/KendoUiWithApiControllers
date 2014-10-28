using System.Linq;
using System.Web.Http;
using System.Web.Http.OData;
using System.Web.Http.OData.Extensions;
using System.Web.Http.OData.Query;
using KendoUiWithApiControllers.Models;

namespace KendoUiWithApiControllers.Controllers
{
	public class KendoUiSampleController : ApiController
	{
		private readonly ApplicationDbContext _context = new ApplicationDbContext();

		public PageResult<Order> GetOrders(ODataQueryOptions<Order> options)
		{
			var settings = new ODataQuerySettings();

			var fromDatabase = _context.Orders.Where(order => order.Freight != 123);

			var results = options.ApplyTo(fromDatabase.AsQueryable(), settings);

			return new PageResult<Order>(
				results as IQueryable<Order>,
				Request.ODataProperties().NextLink,
				Request.ODataProperties().TotalCount);
		}
	}
}