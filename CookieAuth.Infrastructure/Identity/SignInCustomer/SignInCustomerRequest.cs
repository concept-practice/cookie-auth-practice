namespace CookieAuth.Infrastructure.Identity.SignInCustomer
{
    using MediatR;

    public class SignInCustomerRequest : IRequest
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
