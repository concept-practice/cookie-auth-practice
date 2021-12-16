namespace CookieAuth.Application.Customers.Common
{
    using CookieAuth.Domain.Customers;
    using CreateAccount;

    public class CustomerFactory
    {
        public Customer Customer(CreateCustomerAccountRequest request)
        {
            return new Customer(request.Username);
        }

        public CreateCustomerAccountResponse CreateCustomerAccountResponse(Customer customer)
        {
            return new CreateCustomerAccountResponse();
        }
    }
}
