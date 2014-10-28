using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace KendoUiWithApiControllers.Models
{
	public class SampleInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
	{
		protected override void Seed(ApplicationDbContext context)
		{
			IList<Order> defaultOrders = new List<Order>();

			context.Orders.Add(new Order
			{
				Freight = 24.3,
				OrderDate = DateTime.Now.AddDays(-1),
				OrderID = 1,
				ShipCity = "qwer",
				ShipName = "Cherry something"
			});
			context.Orders.Add(new Order
			{
				Freight = 123,
				OrderDate = DateTime.Now.AddDays(-12),
				OrderID = 2,
				ShipCity = "asdf",
				ShipName = "Chocolate"
			});
			context.Orders.Add(new Order
			{
				Freight = 34624.3,
				OrderDate = DateTime.Now.AddDays(-123),
				OrderID = 4,
				ShipCity = "tyui",
				ShipName = "Whatev"
			});
			context.Orders.Add(new Order
			{
				Freight = 327454.3,
				OrderDate = DateTime.Now.AddDays(-144),
				OrderID = 5,
				ShipCity = "fghj",
				ShipName = "Awesome"
			});
			context.Orders.Add(new Order
			{
				Freight = 24.3,
				OrderDate = DateTime.Now.AddDays(-1),
				OrderID = 1,
				ShipCity = "qwer",
				ShipName = "Cheese"
			});
			context.Orders.Add(new Order
			{
				Freight = 24.3,
				OrderDate = DateTime.Now.AddDays(-1),
				OrderID = 1,
				ShipCity = "qwer",
				ShipName = "Cheater"
			});


			base.Seed(context);
		}
	}
}