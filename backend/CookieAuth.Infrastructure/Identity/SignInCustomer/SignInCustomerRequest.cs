namespace CookieAuth.Infrastructure.Identity.SignInCustomer
{
    using MediatR;

    public class SignInCustomerRequest : IRequest
    {
        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
