using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using MyShopCore.Web.API.Models;
using MyShopCore.Web.API.Models.Products;
using MyShopCore.Web.API.Services.Foundations.Products;

namespace MyShopCore.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;


        public ProductsController(IProductService _productService)
        {
            this._productService = _productService;
        }
        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = this._productService.RetrieveAllProducts().ToList();
            return Ok();
        }

        //[HttpGet{"id"},name="Get SingleProduct"]
        //public async   ValueTask<IActionResult> GetAllProductsById(Guid id)
        //{

        //    var product = await this._productService.ReceiveProductByIDAsync(id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}

        [HttpPost]
        public async ValueTask<IActionResult> PostProduct([FromBody] Product product)
        {
            var newProduct = await this._productService.AddProductAsync(product);
            return Created("GetSingleProduct", newProduct);

        }

        [HttpPut]
        public async ValueTask<IActionResult> PutProduct([FromBody] Product product)
        {

            var currentProduct = await this._productService.ReceiveProductByIDAsync(product.Id);

             if (currentProduct != null)
            {
                return NotFound();
            }
            var updateProduct = await this._productService.ModifyProductAsync(product);
            return Ok(updateProduct);

        }


        [HttpDelete]
        public async ValueTask<IActionResult> DeleteProduct(Guid id)
        {

            var currentProduct = await this._productService.ReceiveProductByIDAsync(id);
             if (currentProduct != null)
            {
                return NotFound();
            }
            var deleteProduct = await this._productService.ModifyProductAsync(currentProduct);
            return Ok(deleteProduct);

        }
    }
}
