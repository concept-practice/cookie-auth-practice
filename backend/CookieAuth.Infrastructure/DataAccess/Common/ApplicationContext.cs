namespace CookieAuth.Infrastructure.DataAccess.Common
{
    using CookieAuth.Domain.Customers;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public sealed class ApplicationContext : IdentityDbContext<Customer>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
