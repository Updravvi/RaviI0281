using MiniERP.Context;

namespace MiniERP.Repository
{
    public class SalesLogic:ISalesLogic
    {
        public AppDbContext Context { get; set; }

        public SalesLogic(AppDbContext _context) 
        { 
            Context = _context; 
        }     

    }
}
