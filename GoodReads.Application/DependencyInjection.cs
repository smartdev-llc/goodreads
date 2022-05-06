using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GoodReads.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            return services
                   .AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
