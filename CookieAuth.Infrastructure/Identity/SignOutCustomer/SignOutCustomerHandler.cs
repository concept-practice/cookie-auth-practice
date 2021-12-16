namespace CookieAuth.Infrastructure.Identity.SignOutCustomer
{
    using Domain.Customers;
    using MediatR;
    using Microsoft.AspNetCore.Identity;

    public class SignOutCustomerHandler : IRequestHandler<SignOutCustomerRequest>
    {
        private readonly SignInManager<Customer> _signInManager;

        public SignOutCustomerHandler(SignInManager<Customer> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<Unit> Handle(SignOutCustomerRequest request, CancellationToken cancellationToken)
        {
            await _signInManager.SignOutAsync();

            return Unit.Value;
        }
    }
}
