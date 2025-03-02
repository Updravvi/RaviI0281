using MiniERP.Model;

namespace MiniERP.Repository
{
    public interface ICustomerLogic
    {
        Task AddNewCustomer(Customers customers);
        Task UpdateCustomerById(int id, Customers customers);
    }
}
