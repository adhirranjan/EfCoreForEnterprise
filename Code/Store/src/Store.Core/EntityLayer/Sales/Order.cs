using System;

namespace Store.Core.EntityLayer.Sales
{
	public class Order
	{
		public Order()
		{
		}

		public Int32? OrderID { get; set; }

		public DateTime? OrderDate { get; set; }

		public Int32? CustomerID { get; set; }

		public Int32? EmployeeID { get; set; }

		public Int32? ShipperID { get; set; }

        public String Comments { get; set; }
	}
}
