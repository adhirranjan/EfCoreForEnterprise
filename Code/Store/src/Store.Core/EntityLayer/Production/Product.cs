using System;

namespace Store.Core.EntityLayer.Production
{
	public class Product
	{
		public Product()
		{
		}

		public Int32? ProductID { get; set; }

		public String ProductName { get; set; }

        public Int32? ProductCategoryID { get; set; }

        public String Description { get; set; }
	}
}
