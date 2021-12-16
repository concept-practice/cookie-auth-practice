using MediatR;

namespace CookieAuth.Application.Customers.CreateAccount
{
    public class CreateCustomerAccountRequest : IRequest<CreateCustomerAccountResponse>
    {
        public CreateCustomerAccountRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; }

        public string Password { get; }
    }
}
