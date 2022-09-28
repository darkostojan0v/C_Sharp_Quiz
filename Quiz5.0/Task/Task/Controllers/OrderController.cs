using Microsoft.AspNetCore.Mvc;
using Task.Dtos;
using Task.Services.Interfaces;
using Task.Shared.CustomExceptions;

namespace Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public ActionResult<List<OrderDto>> Get()
        {
            try
            {
                return Ok(_orderService.GetAllOrders());
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured, contact the admin!");
            }
        }

        [HttpGet("{id}")]
        public ActionResult<OrderDto> GetById(int id)
        {
            try
            {
                var orderDto = _orderService.GetById(id);
                return Ok(orderDto);
            }
            catch(OrderNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured, contact the admin!");
            }
        }

        [HttpPost("addOrder")]
        public IActionResult AddOrder([FromBody] AddOrderDto addOrderDto)
        {
            try
            {
                _orderService.AddOrder(addOrderDto);
                return StatusCode(StatusCodes.Status201Created, "Order added.");
            }
            catch(OrderDataException e)
            {
                return BadRequest(e.Message);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured, contact the admin!");
            }
        }

        [HttpPut]
        public IActionResult UpdateOrder([FromBody] UpdateOrderDto updateOrderDto)
        {
            try
            {
                _orderService.UpdateOrder(updateOrderDto);
                return NoContent();
            }
            catch(OrderNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch(OrderDataException e)
            {
                return BadRequest(e.Message);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured, please contact the admin!");
            }
        }

        [HttpDelete]
        public IActionResult DeleteOrder(int id)
        {
            try
            {
                _orderService.DeleteOrder(id);
                return Ok($"Order with id {id} successfully deleted!");
            }
            catch(OrderNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occured, please contact the admin!");
            }
        }

    }
}
