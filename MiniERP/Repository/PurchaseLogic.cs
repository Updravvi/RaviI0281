using MiniERP.Context;

namespace MiniERP.Repository
{
    public class PurchaseLogic :IPurchaseLogic
    {
        public AppDbContext Context { get; set; }

        public PurchaseLogic(AppDbContext _context)
        {
            Context = _context;
        }
    }
}
