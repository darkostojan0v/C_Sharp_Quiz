using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Dtos;

namespace Task.Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderDto> GetAllOrders();
        OrderDto GetById(int id);
        void AddOrder(AddOrderDto order);
        void UpdateOrder(UpdateOrderDto order);
        void DeleteOrder(int id);
        void ByDateRange(DateTime start, DateTime end);
    }
}
