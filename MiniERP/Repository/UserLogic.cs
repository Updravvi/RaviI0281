using MiniERP.Context;
using MiniERP.Model;

namespace MiniERP.Repository
{
    public class UserLogic : IUserLogic
    {
        public AppDbContext Context { get; set; }

        public UserLogic(AppDbContext _context) 
        {
            Context = _context;
        }

        public Task AddNewUser(Users users)
        {
            var User = new Users()
            {
                UserID = users.UserID,
                Name = users.Name,
                Role = users.Role,
            };
            Context.Add(User);
            Context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task UpdateUserById(int id, Users users)
        {
            var User = Context.Users.Find(id);
            if (User is null)
            {
                return Task.CompletedTask;
            }

            User.UserID = users.UserID;
            User.Name = users.Name;
            User.Role = users.Role; 
            Context.SaveChanges();
            return Task.CompletedTask;
        }

    }
}
