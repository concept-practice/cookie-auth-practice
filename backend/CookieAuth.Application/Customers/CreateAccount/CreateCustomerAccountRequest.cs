namespace CookieAuth.Application.Customers.CreateAccount
{
    using MediatR;

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
