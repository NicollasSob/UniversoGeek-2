using MediatR;
using UniversoGeek.Application.Interfaces;
using UniversoGeek.Application.Services;
using UniversoGeek.Domain.Interfaces;
using UniversoGeek.Domain.Shared.Transaction;
using UniversoGeek.Infra.Data.Context;
using UniversoGeek.Infra.Data.Repositories;
using UniversoGeek.Infra.Data.UoW;

namespace UniversoGeek.API.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddMediatr();
            services.AddRepositories();
            services.AddServices();
        }

        public static void AddMediatr(this IServiceCollection services)
        {
            //Você deve adicionar para todos os projetos
            services.AddMediatR(AppDomain.CurrentDomain.Load("UniversoGeek.Domain"));
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            //Você deve adicionar para todos os projetos
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<UniversoGeekDbContext>();

            //Altera para suas classes de repositório
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IOrderItemRepository, OrderItemRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IVoucherRepository, VoucherRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();

        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IAddressAppService, AddressAppService>();
            services.AddScoped<IProductAppService, ProductAppService>();
            services.AddScoped<IVoucherAppService, VoucherAppService>();
            services.AddScoped<IOrderAppService, OrderAppService>();
            services.AddScoped<ICategoryAppService, CategoryAppService>();
            services.AddScoped<IClientAppService, ClientAppService>();
        }
    }
}
