using MiniERP.Model;

namespace MiniERP.Repository
{
    public interface ISuppliersLogic
    {
        Task AddNewSuppliers(Suppliers suppliers);
        Task UpdateSuppliersById(int id, Suppliers suppliers);
    }
}
