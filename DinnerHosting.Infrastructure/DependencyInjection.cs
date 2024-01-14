using DinnerHosting.Application.Common.Interfaces.Authentication;
using DinnerHosting.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace DinnerHosting.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            return services;
        }
    }
}
