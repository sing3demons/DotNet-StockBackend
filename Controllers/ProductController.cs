namespace StockBackend.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using StockBackend.DTOs;

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost("")]
        public async Task<IActionResult> PostProductAsync([FromBody] ProductRequest request)
        {

            return Ok();

        }
    }
}