using System;
using System.Collections.Generic;
using System.Linq;
using Store.Core.DataLayer.Contracts;
using Store.Core.EntityLayer.Sales;

namespace Store.Core.DataLayer.Repositories
{
    public class SalesRepository : Repository, ISalesRepository
    {
        public SalesRepository(StoreDbContext dbContext)
            : base(dbContext)
        {
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return DbContext.Set<Customer>();
        }

        public Customer GetCustomer(Customer entity)
        {
            return DbContext.Set<Customer>().FirstOrDefault(item => item.CustomerID == entity.CustomerID);
        }

        public void AddCustomer(Customer entity)
        {
            DbContext.Set<Customer>().Add(entity);

            DbContext.SaveChanges();
        }

        public void UpdateCustomer(Customer changes)
        {
            var entity = GetCustomer(changes);

            if (entity != null)
            {
                entity.CompanyName = changes.CompanyName;
                entity.ContactName = changes.ContactName;

                DbContext.SaveChanges();
            }
        }

        public void DeleteCustomer(Customer entity)
        {
            DbContext.Set<Customer>().Remove(entity);

            DbContext.SaveChanges();
        }

        public IEnumerable<Order> GetOrders(Int32 pageSize, Int32 pageNumber)
        {
            var query = DbContext.Set<Order>().AsQueryable();

            return query.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }

        public Order GetOrder(Order entity)
        {
            return DbContext.Set<Order>().FirstOrDefault(item => item.OrderID == entity.OrderID);
        }

        public void AddOrder(Order entity)
        {
            DbContext.Set<Order>().Add(entity);

            DbContext.SaveChanges();
        }

        public void UpdateOrder(Order changes)
        {
            var entity = GetOrder(changes);

            if (entity != null)
            {
                entity.OrderDate = changes.OrderDate;
                entity.CustomerID = changes.CustomerID;
                entity.EmployeeID = changes.EmployeeID;
                entity.ShipperID = changes.ShipperID;
                entity.Comments = changes.Comments;

                DbContext.SaveChanges();
            }
        }

        public void DeleteOrder(Order entity)
        {
            DbContext.Set<Order>().Remove(entity);

            DbContext.SaveChanges();
        }

        public IEnumerable<OrderDetail> GetOrderDetails()
        {
            return DbContext.Set<OrderDetail>();
        }

        public OrderDetail GetOrderDetail(OrderDetail entity)
        {
            return DbContext.Set<OrderDetail>().FirstOrDefault(item => item.OrderID == entity.OrderID && item.ProductID == entity.ProductID);
        }

        public void AddOrderDetail(OrderDetail entity)
        {
            DbContext.Set<OrderDetail>().Add(entity);

            DbContext.SaveChanges();
        }

        public void UpdateOrderDetail(OrderDetail changes)
        {
            var entity = GetOrderDetail(changes);

            if (entity != null)
            {
                entity.ProductID = changes.ProductID;
                entity.ProductName = changes.ProductName;
                entity.UnitPrice = changes.UnitPrice;
                entity.Quantity = changes.Quantity;
                entity.Total = changes.Total;

                DbContext.SaveChanges();
            }
        }

        public void DeleteOrderDetail(OrderDetail entity)
        {
            DbContext.Set<OrderDetail>().Remove(entity);

            DbContext.SaveChanges();
        }

        public IEnumerable<Shipper> GetShippers()
        {
            return DbContext.Set<Shipper>();
        }

        public Shipper GetShipper(Shipper entity)
        {
            return DbContext.Set<Shipper>().FirstOrDefault(item => item.ShipperID == entity.ShipperID);
        }

        public void AddShipper(Shipper entity)
        {
            DbContext.Set<Shipper>().Add(entity);

            DbContext.SaveChanges();
        }

        public void UpdateShipper(Shipper changes)
        {
            var entity = GetShipper(changes);

            if (entity != null)
            {
                entity.CompanyName = changes.CompanyName;
                entity.ContactName = changes.ContactName;

                DbContext.SaveChanges();
            }
        }

        public void DeleteShipper(Shipper entity)
        {
            DbContext.Set<Shipper>().Remove(entity);

            DbContext.SaveChanges();
        }
    }
}
