using DinnerHosting.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace DinnerHosting.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            return services;
        }
    }
}
