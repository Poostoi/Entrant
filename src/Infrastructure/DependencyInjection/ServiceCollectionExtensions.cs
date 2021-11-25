using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDI(this IServiceCollection service)
        {
            return service;
        }
    }
}