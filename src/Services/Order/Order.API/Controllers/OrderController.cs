using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            using (var context = new OrderDbContext())
            {
                // Truy vấn dữ liệu
                var product = await context.Orders.FindAsync(id);

                if (product == null)
                {
                    return BadRequest();
                }

                return Ok(product);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Models.Order product)
        {
            using (var context = new OrderDbContext())
            {
                if (product == null)
                {
                    return BadRequest();
                }

                // Thêm dữ liệu
                context.Orders.Add(product);
                var result = await context.SaveChangesAsync();

                return Ok(result);
            }
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Models.Order> GetAll()
        {
            using (var context = new OrderDbContext())
            {
                // Truy vấn dữ liệu
                var products = context.Orders.ToList();

                return products;
            }
        }

        [HttpPut]
        public Models.Order Put()
        {
            var product = new Models.Order();

            return product;
        }

        [HttpDelete]
        public Models.Order Delete()
        {
            var product = new Models.Order();

            return product;
        }
    }
}
