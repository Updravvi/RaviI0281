using Microsoft.AspNetCore.Mvc;
using MiniERP.Context;
using MiniERP.Repository;

namespace MiniERP.Controllers
{
    [Route("api/Sales")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        public ISalesLogic SalesLogic { get; set; }
        public AppDbContext Context { get; set; }

        public SalesController (ISalesLogic  salesLogic, AppDbContext context)
        {
            SalesLogic = salesLogic;
            Context = context;
        }

        [HttpGet]
        [Route("/GetSalesOrder")]
        public IActionResult GetSalesOrder()
        {
            var salesOrders = Context.SalesOrder.ToList();
            return Ok(salesOrders);
        }
    }
}
