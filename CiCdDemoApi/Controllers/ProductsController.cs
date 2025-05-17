using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CiCdDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new[]
            {
                new { Id = 1, Name = "Samsung", Price = 23232 },
                new { Id = 2, Name = "Apple", Price = 45000 },
                new { Id = 3, Name = "Xiaomi", Price = 15000 }
            };

            return Ok(products);
        }

      
    }
}
