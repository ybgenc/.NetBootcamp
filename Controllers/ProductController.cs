using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netBootcamp.Models;

namespace netBootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        static List<Product> products;
        public ProductController()
        {
            if (products == null)
                products = ProductService.GetProducts();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = products.FirstOrDefault(x => x.ID == id);
            if(product == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(product);
            }
        }
        [HttpPost]
        public IActionResult Post(Product product)
        {
            var products = ProductService.GetProducts();

            int newId = products.Count + 1;

            product.ID = newId;

            products.Add(product);

            return StatusCode(StatusCodes.Status201Created, product);
        }


    }
}
