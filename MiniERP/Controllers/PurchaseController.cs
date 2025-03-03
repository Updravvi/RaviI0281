using Microsoft.AspNetCore.Mvc;
using MiniERP.Context;
using MiniERP.Repository;

namespace MiniERP.Controllers
{
    [Route("api/Purchase")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        public IPurchaseLogic PurchaseLogic { get; set; }
        public AppDbContext Context { get; set; }

        public PurchaseController(IPurchaseLogic purchaseLogic,AppDbContext context) 
        {
            PurchaseLogic = purchaseLogic;
            Context = context;
        }

        [HttpGet]
        [Route("/GetPurchaseOrders")]
        public IActionResult GetPurchaseOrder()
        {
            var purchaseOrders = Context.PurchaseOrder.ToList();
            return Ok(purchaseOrders);
        }
    }
}
