namespace CookieAuth.Domain.Customers
{
    using Microsoft.AspNetCore.Identity;

    public sealed class Customer : IdentityUser
    {
        public Customer(string username)
            : this()
        {
            UserName = username;
        }

        private Customer()
        {
        }
    }
}
