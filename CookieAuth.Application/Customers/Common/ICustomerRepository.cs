namespace CookieAuth.Application.Customers.Common
{
    using CookieAuth.Domain.Customers;
    using Microsoft.AspNetCore.Identity;

    public interface ICustomerRepository
    {
        Task<IdentityResult> CreateCustomer(Customer customer, string password);
    }
}
