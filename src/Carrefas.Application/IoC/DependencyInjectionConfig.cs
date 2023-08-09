using Carrefas.Application.Interfaces;
using Carrefas.Application.Services;
using Carrefas.Data.Context;
using Carrefas.Data.Repositories;
using Carrefas.Domain.Interfaces.Notifications;
using Carrefas.Domain.Interfaces.Repositories;
using Carrefas.Domain.Interfaces.Services;
using Carrefas.Domain.Notifications;
using Carrefas.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Carrefas.Application.IoC
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            //Carrefas.Data
            services.AddScoped<CarrefasContext>();

            //Carrefas.Domain
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();
            services.AddScoped<INotifier, Notifier>();

            //Carrefas.Application
            services.AddScoped<IProdutoApplicationService, ProdutoApplicationService>();

            return services;
        }
    }
}
