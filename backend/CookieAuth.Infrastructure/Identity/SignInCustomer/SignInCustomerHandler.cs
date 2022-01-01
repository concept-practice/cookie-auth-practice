namespace CookieAuth.Infrastructure.Identity.SignInCustomer
{
    using Domain.Customers;
    using MediatR;
    using Microsoft.AspNetCore.Identity;

    public class SignInCustomerHandler : IRequestHandler<SignInCustomerRequest>
    {
        private readonly SignInManager<Customer> _signInManager;

        public SignInCustomerHandler(SignInManager<Customer> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<Unit> Handle(SignInCustomerRequest request, CancellationToken cancellationToken)
        {
            await _signInManager.PasswordSignInAsync(request.Username, request.Password, true, false);

            return Unit.Value;
        }
    }
}
