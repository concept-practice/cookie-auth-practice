namespace CookieAuth.Application.Customers.CreateAccount
{
    using Common;
    using MediatR;

    public class CreateCustomerAccountHandler : IRequestHandler<CreateCustomerAccountRequest, CreateCustomerAccountResponse>
    {
        private readonly CustomerFactory _customerFactory;
        private readonly ICustomerRepository _customerRepository;

        public CreateCustomerAccountHandler(CustomerFactory customerFactory, ICustomerRepository customerRepository)
        {
            _customerFactory = customerFactory;
            _customerRepository = customerRepository;
        }

        public async Task<CreateCustomerAccountResponse> Handle(CreateCustomerAccountRequest request, CancellationToken cancellationToken)
        {
            var customer = _customerFactory.Customer(request);

            var result = await _customerRepository.CreateCustomer(customer, request.Password);

            return _customerFactory.CreateCustomerAccountResponse(customer);
        }
    }
}
