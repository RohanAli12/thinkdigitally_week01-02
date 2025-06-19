using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Think_Digitally_week01.Models;
using Think_Digitally_week01.Services;

namespace Think_Digitally_week01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            return Ok(_productService.AddProduct(product));
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok(_productService.GetAllProducts());
        }

        [HttpPut]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            return Ok(_productService.UpdateProduct(product));
        }

        [HttpDelete]
        public IActionResult DeleteProduct([FromBody] Product product)
        {
            _productService.DeleteProduct(product);
            return Ok($"Product with ID {product.Id} deleted successfully.");
        }
    }
}
