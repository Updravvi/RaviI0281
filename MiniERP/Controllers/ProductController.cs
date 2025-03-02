using Microsoft.AspNetCore.Mvc;
using MiniERP.Context;
using MiniERP.Model;
using MiniERP.Repository;

namespace MiniERP.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductController :ControllerBase
    {
        public IProductLogic ProductLogic { get; set; }
        public AppDbContext Context { get; set; }

        public ProductController(IProductLogic productLogic, AppDbContext context) 
        {
            ProductLogic = productLogic;
            Context = context;
        }

        [HttpPost]
        [Route("/AddProduct")]
        public IActionResult AddProduct([FromBody] Products prod)
        {
            var p = ProductLogic.AddNewProduct(prod);
            return Ok(p);
        }

        [HttpGet]
        [Route("/GetAllProduct")]
        public IActionResult GetProducts()
        {
            var AllProduct = Context.Products.ToList();
            return Ok(AllProduct);
        }

        [HttpPut]
        [Route("/UpdateProduct/{id}")]
        public IActionResult UpdateProductById(int id, [FromBody] Products product)
        {
            ProductLogic.UpdateProductById(id, product);
            return Ok();
        }

        [HttpDelete]
        [Route("/DeleteProduct/{id}")]
        public IActionResult DeleteProductById(int id)
        {
            var Prod = Context.Products.Find(id);
            if (Prod == null)
            {
                return NotFound();
            }
            Context.Products.Remove(Prod);
            Context.SaveChanges();
            return Ok();
        }

    }
}
