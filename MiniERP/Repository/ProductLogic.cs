using MiniERP.Context;
using MiniERP.Model;

namespace MiniERP.Repository
{
    public class ProductLogic : IProductLogic
    {
        public AppDbContext Context { get; set; }

        public ProductLogic(AppDbContext _context)
        {
            Context = _context;
        }

        public Task AddNewProduct(Products products)
        {
            var Prod = new Products()
            {
                ItemNo = products.ItemNo,
                Description = products.Description,
                Price = products.Price,
                Quantity = products.Quantity,
            };
            Context.Add(Prod);
            Context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task UpdateProductById(int id, Products products)
        {

            var Prod = Context.Products.Find(id);
            if (Prod is null)
            {
                return Task.CompletedTask;
            }
           
            Prod.Description = products.Description;
            Prod.Price = products.Price;
            Context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
