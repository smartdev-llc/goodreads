using GoodReads.Application.BookServices.Queries;
using GoodReads.Application.UserServices.Commands;
using GoodReads.Domain.Books;
using GoodReads.Domain.Shared;
using GoodReads.Domain.Users;
using GoodReads.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace GoodReads.Api
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services) =>
            services
                .AddScoped<AddBookHandler>()
                .AddScoped<GetAllReadBookHandler>()
                .AddScoped<GetBookByNameHandler>();

        public static IServiceCollection AddDatabase(this IServiceCollection services)
        {
            services
            .AddDbContext<GoodReadDBContext>(options => options.UseInMemoryDatabase("GoodReadDB"),
                                             ServiceLifetime.Scoped);
            var ServiceProvider = services.BuildServiceProvider();
            using (var dbContext = ServiceProvider.GetService<GoodReadDBContext>())
            {
                dbContext.Users.Add(new User()
                {
                    Id = 1,
                    Name = "Jonh",
                    Books = new List<Book>()
                    {
                        new Book("Harry Potter", "J. K. Rowling", BookStatus.FinishedReading)
                    }
                });

                dbContext.Users.Add(new User()
                {
                    Id = 2,
                    Name = "Henry",
                    Books = new List<Book>()
                    {
                        new Book("A Brief History of Humankind", "Yuval Noah Harari", BookStatus.Reading)
                    }
                });
                dbContext.SaveChanges();
            }
            return services;
        }
    }
}
