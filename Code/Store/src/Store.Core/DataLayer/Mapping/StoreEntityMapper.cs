using System.Collections.Generic;
using Store.Core.DataLayer.Mapping.HumanResources;
using Store.Core.DataLayer.Mapping.Production;
using Store.Core.DataLayer.Mapping.Sales;

namespace Store.Core.DataLayer.Mapping
{
    public class StoreEntityMapper : EntityMapper
    {
        public StoreEntityMapper()
        {
            Mappings = new List<IEntityMap>()
            {
                new EventLogMap() as IEntityMap,
                new ProductMap() as IEntityMap,
                new ProductCategoryMap() as IEntityMap,
                new ProductInventoryMap() as IEntityMap,
                new CustomerMap() as IEntityMap,
                new EmployeeMap() as IEntityMap,
                new ShipperMap() as IEntityMap,
                new OrderMap() as IEntityMap,
                new OrderDetailMap() as IEntityMap,
                new OrderSummaryMap() as IEntityMap
            };
        }
    }
}
