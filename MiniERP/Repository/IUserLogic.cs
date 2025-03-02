using MiniERP.Model;

namespace MiniERP.Repository
{
    public interface IUserLogic
    {
        Task AddNewUser(Users users);
        Task UpdateUserById(int id, Users users);
    }
}
