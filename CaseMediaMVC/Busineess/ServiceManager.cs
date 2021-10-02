using System;
using CaseMediaMVC.Busineess.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CaseMediaMVC.Busineess
{
    public static class ServiceManager
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<INewsService, NewsService>();
        }
    }
}
