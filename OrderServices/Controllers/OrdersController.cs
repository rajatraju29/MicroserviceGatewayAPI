using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderServices.Data;
using OrderServices.DTO;
using OrderServices.Entities;

namespace OrderServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController(OrderSerDbContext _context) : ControllerBase
    {
        [Authorize]
        [HttpGet]
        public IActionResult GetOrders()
        {
            var orders = _context.Orders.ToList();
            return Ok(orders);
        }
        [Authorize]
        public IActionResult GetOrderById(int id)
        {
            var order = _context.Orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);

        }
        [Authorize]
        [HttpPost("CreateOrder")]   
        public IActionResult createOrders(OrderDTO order)
        {
            var newOrder = new Orders
            {
                Id = order.Id,
                IsPayment = order.IsPayment,    
                CreatedData = order.CreatedData,
                status = order.status,
                UserId = order.UserId
            };
            _context.Orders.Add(newOrder);
            _context.SaveChanges();
            return Ok(order);
        }   
    }
}
