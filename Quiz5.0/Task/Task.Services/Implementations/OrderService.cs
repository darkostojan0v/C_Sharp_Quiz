using Task.DataAccess.Migrations;
using Task.Domain.Models;
using Task.Dtos;
using Task.Services.Interfaces;
using Task.Shared.CustomExceptions;
using Task.Mappers;

namespace Task.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> _orderRepository;

        public OrderService(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void AddOrder(AddOrderDto addOrderDto)
        {
            if (string.IsNullOrEmpty(addOrderDto.Text))
            {
                throw new OrderDataException("Text is required field!");
            }

            if (addOrderDto.Text.Length > 100)
            {
                throw new OrderDataException("Text can not contain more than 100 characters..");
            }

            Order newOrder = addOrderDto.ToOrder();
            newOrder.Text = addOrderDto.Text;

            _orderRepository.Add(newOrder);
        }

        public void ByDateRange(DateTime start, DateTime end)
        {
            
            if(start.Date == null || end.Date == null)
            {
                throw new OrderDataException("The date can not be null!");
            }

        }

        public void DeleteOrder(int id)
        {
            Order orderDb = _orderRepository.GetById(id);
            if (orderDb == null)
            {
                throw new OrderNotFoundException($"Order with id {id} was not found!");
            }

            _orderRepository.Delete(orderDb);
        }

        public List<OrderDto> GetAllOrders()
        {
            var ordersDb = _orderRepository.GetAll();
            return ordersDb.Select(x => x.ToOrderDto()).ToList();
        }

        public OrderDto GetById(int id)
        {
            Order orderDB = _orderRepository.GetById(id);
            if (orderDB == null)
            {
                throw new OrderNotFoundException($"Order with id {id} was not found!");
            }

            OrderDto orderDto = orderDB.ToOrderDto();
            return orderDto;

        }

        public void UpdateOrder(UpdateOrderDto order)
        {
            Order orderDb = _orderRepository.GetById(order.Id);
            if (orderDb == null)
            {
                throw new OrderNotFoundException($"Order with id {order.Id} was not found!");
            }

            if (string.IsNullOrEmpty(order.Text))
            {
                throw new OrderDataException("Text is required field!");
            }

            if (order.Text.Length > 100)
            {
                throw new OrderDataException("Text can not contain more than 100 characters..");
            }

            orderDb.Text = order.Text;
            orderDb.Priority = order.Priority;

            _orderRepository.Update(orderDb);
        }
    }
}
