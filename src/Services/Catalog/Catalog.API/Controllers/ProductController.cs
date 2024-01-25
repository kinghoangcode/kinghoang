using Catalog.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            using (var context = new CatalogDbContext())
            {
                // Truy vấn dữ liệu
                var product = await context.Products.FindAsync(id);

                if (product == null)
                {
                    return BadRequest();
                }

                return Ok(product);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Product product)
        {
            using (var context = new CatalogDbContext())
            {
                if (product == null)
                {
                    return BadRequest();
                }

                // Thêm dữ liệu
                context.Products.Add(product);
                var result = await context.SaveChangesAsync();

                return Ok(result);
            }
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Product> GetAll()
        {
            using (var context = new CatalogDbContext())
            {
                // Truy vấn dữ liệu
                var products = context.Products.ToList();

                return products;
            }
        }

        [HttpPut]
        public Product Put()
        {
            var product = new Product();

            return product;
        }

        [HttpDelete]
        public Product Delete()
        {
            var product = new Product();

            return product;
        }
    }
}
