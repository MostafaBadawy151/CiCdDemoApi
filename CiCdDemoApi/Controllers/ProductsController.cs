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
            return Ok(new {Id = 1, Name= "Samsung", Price = 23232});
        }
    }
}
