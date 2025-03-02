using MiniERP.Context;
using MiniERP.Model;

namespace MiniERP.Repository
{
    public class SuppliersLogic : ISuppliersLogic
    {
        public AppDbContext Context { get; set; }

        public SuppliersLogic(AppDbContext _context) 
        {
            Context = _context; 
        }

        Task ISuppliersLogic.AddNewSuppliers(Suppliers suppliers)
        {
            var Sup = new Suppliers()
            {
                VendorNo = suppliers.VendorNo,
                Name = suppliers.Name,
            };
            Context.Add(Sup);
            Context.SaveChanges();
            return Task.CompletedTask;
        }

        Task ISuppliersLogic.UpdateSuppliersById(int id, Suppliers suppliers)
        {
            var Supr = Context.Suppliers.Find(id);
            if (Supr is null)
            {
                return Task.CompletedTask;
            }

            Supr.VendorNo = suppliers.VendorNo;
            Supr.Name = suppliers.Name;
            Context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
