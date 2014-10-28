using System;

namespace KendoUiWithApiControllers.Models
{
	public class Order
	{
		public int OrderID { get; set; }
		public double Freight { get; set; }
		public string ShipName { get; set; }
		public DateTimeOffset OrderDate { get; set; }
		public string ShipCity { get; set; }
	}
}