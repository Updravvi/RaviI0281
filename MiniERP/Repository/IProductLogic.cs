using MiniERP.Model;

namespace MiniERP.Repository
{
    public interface IProductLogic
    {
        Task AddNewProduct(Products products);
        Task UpdateProductById(int id, Products products);
    }
}
