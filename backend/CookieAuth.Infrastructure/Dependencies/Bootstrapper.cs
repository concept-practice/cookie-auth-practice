namespace CookieAuth.Infrastructure.Dependencies
{
    using System.Reflection;
    using DataAccess.Common;
    using Domain.Customers;
    using MediatR;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class Bootstrapper
    {
        public static void Register(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(x =>
            {
                x.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SecurityPractice;Trusted_Connection=True;MultipleActiveResultSets=true");
            });

            services.AddIdentity<Customer, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationContext>()
                .AddDefaultTokenProviders()





            services.AddAuthentication().AddCookie();

            services.AddMediatR(Assembly.Load("CookieAuth.Application"), Assembly.Load("CookieAuth.Infrastructure"));

            GetTypes("CookieAuth.Infrastructure", "Repository")
                .ForEach(type => services.AddTransient(type.GetInterfaces().First(x => x.Name.EndsWith("Repository")), type));

            GetTypes("CookieAuth.Application", "Factory")
                .ForEach(type => services.AddTransient(type));
        }

        public static List<Type> GetTypes(string assembly, string typeName)
        {
            return Assembly.Load(assembly)
                .GetTypes()
                .Where(type => !type.IsAbstract || !type.IsInterface)
                .Where(type => type.Name.EndsWith(typeName))
                .ToList();
        }
    }
}
