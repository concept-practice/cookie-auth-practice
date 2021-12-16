namespace CookieAuth.Infrastructure.DataAccess.Customers
{
    using CookieAuth.Application.Customers.Common;
    using CookieAuth.Domain.Customers;
    using Microsoft.AspNetCore.Identity;

    public class CustomerRepository : ICustomerRepository
    {
        private readonly UserManager<Customer> _userManager;

        public CustomerRepository(UserManager<Customer> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> CreateCustomer(Customer customer, string password)
        {
            return await _userManager.CreateAsync(customer, password);
        }
    }
}
