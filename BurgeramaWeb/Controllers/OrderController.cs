using BurgeramaWeb.Interfaces;
using BurgeramaWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BurgeramaWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Order>))]
        public IActionResult GetOrders()
        {
            var orders = _orderRepository.GetOrders();

            if (orders == null) return Ok("No Orders available :(");

            return Ok(orders);
        }
    }
}
