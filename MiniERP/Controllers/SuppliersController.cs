using Microsoft.AspNetCore.Mvc;
using MiniERP.Context;
using MiniERP.Model;
using MiniERP.Repository;

namespace MiniERP.Controllers
{
    [Route("/Supplier")]
    [ApiController]
    public class SuppliersController: ControllerBase
    {
        public ISuppliersLogic SuppliersLogic { get; set; }
        public AppDbContext Context { get; set; }

        public SuppliersController(ISuppliersLogic suppliersLogic,AppDbContext context)
        {
            SuppliersLogic = suppliersLogic;
            Context = context;
        }

        [HttpPost]
        [Route("/AddSuppliers")]
        public IActionResult AddSuppliers([FromBody] Suppliers suppliers)
        {
            var s = SuppliersLogic.AddNewSuppliers(suppliers);
            return Ok(s);
        }

        [HttpGet]
        [Route("/GetAllSuppliers")]
        public IActionResult GetProducts()
        {
            var AllSupplier = Context.Suppliers.ToList();
            return Ok(AllSupplier);
        }

        [HttpPut]
        [Route("/UpdateSupplier/{id}")]
        public IActionResult UpdateCustomerById(int id, [FromBody] Suppliers supplierst)
        {
            var Sup = Context.Suppliers.Find(id);
            if (Sup == null)
            {
                return NotFound();
            }
            SuppliersLogic.UpdateSuppliersById(id, supplierst);
            return Ok();
        }

        [HttpDelete]
        [Route("/DeleteSupplier/{id}")]
        public IActionResult DeleteSupplierById(int id)
        {
            var Sup = Context.Suppliers.Find(id);
            if (Sup == null)
            {
                return NotFound();
            }
            Context.Suppliers.Remove(Sup);
            Context.SaveChanges();
            return Ok();
        }
    }
}
