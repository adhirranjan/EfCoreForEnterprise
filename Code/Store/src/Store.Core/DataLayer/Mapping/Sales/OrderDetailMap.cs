using Microsoft.EntityFrameworkCore;
using Store.Core.EntityLayer.Sales;

namespace Store.Core.DataLayer.Mapping.Sales
{
    public class OrderDetailMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<OrderDetail>();

            entity.ToTable("OrderDetail", "Sales");

            entity.HasKey(p => new { p.OrderID, p.ProductID });
        }
    }
}
