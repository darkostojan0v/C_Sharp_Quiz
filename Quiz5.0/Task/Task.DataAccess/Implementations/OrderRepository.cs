using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DataAccess.Migrations;
using Task.Domain.Models;

namespace Task.DataAccess.Implementations
{
    public class OrderRepository : IRepository<Order>
    {
        private OrderDbContext _orderDbContext;

        public OrderRepository(OrderDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;
        }

        public void Add(Order entity)
        {
            _orderDbContext.Orders.Add(entity);
            _orderDbContext.SaveChanges();
        }

        public void ByDateRange(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void Delete(Order entity)
        {
            _orderDbContext.Orders.Remove(entity);
            _orderDbContext.SaveChanges();
        }

        public List<Order> GetAll()
        {
            return _orderDbContext.Orders
                .ToList();
        }

        public Order GetById(int id)
        {
            return _orderDbContext.Orders
                .FirstOrDefault(x => x.Id == id);
        }

        public void Update(Order entity)
        {
            _orderDbContext.Orders.Update(entity);
            _orderDbContext.SaveChanges();
        }
    }
}
