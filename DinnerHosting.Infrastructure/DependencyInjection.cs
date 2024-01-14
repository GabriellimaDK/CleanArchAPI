using DinnerHosting.Application.Common.Interfaces.Authentication;
using DinnerHosting.Application.Common.Interfaces.Services;
using DinnerHosting.Infrastructure.Authentication;
using DinnerHosting.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DinnerHosting.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            return services;
        }
    }
}
