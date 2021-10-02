using CaseMediaMVC.Data.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CaseMediaMVC.Data
{
    public static class RepositoryManager
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<INewsRepository, NewsRepository>();
        }
    }
}
