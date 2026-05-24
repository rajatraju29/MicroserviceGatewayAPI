using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrders()
        {
            // Sample data for demonstration purposes
            var orders = new[]
            {
                new { Id = 1, Product = "Laptop", Quantity = 2 },
                new { Id = 2, Product = "Smartphone", Quantity = 5 },
                new { Id = 3, Product = "Headphones", Quantity = 10 }
            };
            return Ok(orders);
        }
    }
}
