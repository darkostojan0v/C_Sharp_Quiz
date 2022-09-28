using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.DataAccess.Implementations;
using Task.DataAccess.Migrations;
using Task.Domain.Models;
using Task.Services.Implementations;
using Task.Services.Interfaces;

namespace Task.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static void InjectDbContext(IServiceCollection services)
        {
            services.AddDbContext<OrderDbContext>(x =>
            x.UseSqlServer("Server=.\\SQLExpress;Database=OrderAppDb;Trusted_Connection=True"));
        }

        public static void InjectRepositories(IServiceCollection services)
        {
            services.AddTransient<IRepository<Order>, OrderRepository>();
        }

        public static void InjectServices(IServiceCollection services)
        {
            services.AddTransient<IOrderService, OrderService>();
        }
    }
}
