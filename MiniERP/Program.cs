
using Microsoft.EntityFrameworkCore;
using MiniERP.Context;
using MiniERP.Repository;

namespace MiniERP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

           // builder.Services.AddDbContext<AppDbContext>();

            builder.Services.AddScoped<IUserLogic,UserLogic>();
            builder.Services.AddScoped<ICustomerLogic,CustomerLogic>();
            builder.Services.AddScoped<ISuppliersLogic,SuppliersLogic>();
            builder.Services.AddScoped<IProductLogic,ProductLogic>();
            builder.Services.AddScoped<IPurchaseLogic, PurchaseLogic>();
            builder.Services.AddScoped<ISalesLogic, SalesLogic>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
