using AutoMapper;
using GoodReads.Application;
using GoodReads.Application.Abstract;
using GoodReads.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace GoodReads.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services)
            => services
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IBookRepository, BookRepository>()
                .AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
