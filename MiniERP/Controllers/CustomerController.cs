using Microsoft.AspNetCore.Mvc;
using MiniERP.Repository;
using MiniERP.Model;
using MiniERP.Context;

namespace MiniERP.Controllers
{
    [Route("api/Customer")]
    [ApiController]
    public class CustomerController:ControllerBase
    {
        public ICustomerLogic CustomerLogic { get; set; }
        public AppDbContext  Context { get; set; }
      
        public CustomerController(ICustomerLogic customerLogic, AppDbContext context)
        {
            CustomerLogic = customerLogic;
            Context = context;
        }

        [HttpPost]
        [Route("/AddCustomer")]
        public IActionResult AddCustomer([FromBody] Customers cust)
        {
            var c = CustomerLogic.AddNewCustomer(cust);
            return Ok(c);
        }

        [HttpGet]
        [Route("/GetAllCustomer")]
        public IActionResult GetCustomer()
        {
            var AllCust= Context.Customers.ToList();
            return Ok(AllCust); 
        }

        [HttpGet]
        [Route("/GetCustomerById/{id}")]
        public IActionResult GetCustomerById(int id)
        {
            var AllCust = Context.Customers.Find(id);
            if (AllCust == null) 
            {
                return NotFound(); 
            }
            return Ok(AllCust);
        }

        [HttpPut]
        [Route("/UpdateCustomer/{id}")]
        public IActionResult UpdateCustomerById(int id, [FromBody] Customers cust)
        {
           CustomerLogic.UpdateCustomerById(id,cust);
           return Ok();
        }

        [HttpDelete]
        [Route("/DeleteCustomer/{id}")]
        public IActionResult DeleteCustomerById(int id)
        {
            var Cust = Context.Customers.Find(id);
            if (Cust == null)
            {
                return NotFound();
            }
            Context.Customers.Remove(Cust);
            Context.SaveChanges();
            return Ok();
        }

    }
}
