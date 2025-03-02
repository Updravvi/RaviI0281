using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using MiniERP.Context;
using MiniERP.Model;
using System.Net;
using System.Xml.Linq;

namespace MiniERP.Repository
{
    public class CustomerLogic : ICustomerLogic
    {
        public AppDbContext Context { get; set; }

        public CustomerLogic(AppDbContext _context) 
        {
            Context = _context;
        }

        public Task AddNewCustomer(Customers customers)
        {
            var Cust = new Customers()
            {
                CustomerNo = customers.CustomerNo,
                Name = customers.Name,
                Address = customers.Address,
                PhoneNo = customers.PhoneNo,
            };
            Context.Add(Cust);
            Context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task UpdateCustomerById(int id, Customers customer)
        {
            var Cust = Context.Customers.Find(id);
            if (Cust is null)
            {
                return Task.CompletedTask;
            }  

            Cust.Name = customer.Name;
            Cust.Address = customer.Address;
            Cust.PhoneNo = customer.PhoneNo;
            Context.SaveChanges();
            return Task.CompletedTask;
        }

    }
}
