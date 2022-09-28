using Task.Domain.Models;
using Task.Dtos;

namespace Task.Mappers
{
    public static class OrderMapper
    {
        public static OrderDto ToOrderDto(this Order order)
        {
            return new OrderDto
            {
                Text = order.Text,
                Priority = order.Priority
            };
        }

        public static Order ToOrder(this AddOrderDto addOrderDto)
        {
            return new Order()
            {
                Text = addOrderDto.Text,
                Priority = addOrderDto.Priority
            };
        }

        public static Order ToOrder(this UpdateOrderDto updateOrderDto, Order orderDb)
        {
            orderDb.Text = updateOrderDto.Text;

            return orderDb;
        }
    }
}
