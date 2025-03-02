using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MiniERP.Context;
using MiniERP.Model;
using MiniERP.Repository;

namespace MiniERP.Controllers
{

    [Route("api/User")]
    [ApiController]
    public class UserController : Controller
    {
        public IUserLogic UserLogic {  get; set; }
        public AppDbContext Context { get; set; }

        public UserController (IUserLogic userLogic, AppDbContext context) 
        {
            UserLogic = userLogic;
            Context = context;
        }

        [HttpPost]
        [Route("/AddUser")]
        public IActionResult AddUser([FromBody] Users user)
        {
            var u = UserLogic.AddNewUser(user);
            return Ok(u);
        }

        [HttpGet]
        [Route("/GetAllUser")]
        public IActionResult GetAllUser()
        {
            var AllUser = Context.Users.ToList();
            return Ok(AllUser);
        }

        [HttpPut]
        [Route("/UpdateUser/{id}")]
        public IActionResult UpdateUserById(int id, [FromBody] Users user)
        {
            var User = Context.Users.Find(id);
            if (User == null)
            {
                return NotFound();
            }
            UserLogic.UpdateUserById(id, user);
            return Ok();
        }

        [HttpDelete]
        [Route("/DeleteUser/{id}")]
        public IActionResult DeleteUserById(int id)
        {
            var User = Context.Users.Find(id);
            if (User == null)
            {
                return NotFound();
            }
            Context.Users.Remove(User);
            Context.SaveChanges();
            return Ok();
        }

    }
}
