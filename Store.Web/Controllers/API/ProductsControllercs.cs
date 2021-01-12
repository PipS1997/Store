

namespace Store.Web.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using Store.Web.Data;

    [Route("api/[Controller]")]
    public class ProductsControllercs : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductsControllercs(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(this.productRepository.GetAll());
        }    
    }
}
