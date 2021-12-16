namespace CookieAuth.API.Controllers
{
    using Application.Customers.CreateAccount;
    using CookieAuth.Infrastructure.Identity.SignOutCustomer;
    using Infrastructure.Identity.SignInCustomer;
    using MediatR;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpPost("AddCustomer", Name = "AddCustomer")]
        [ProducesResponseType(typeof(CreateCustomerAccountResponse), StatusCodes.Status201Created)]
        public async Task<IActionResult> AddCustomerAccount(CreateCustomerAccountRequest request)
        {
            var result = await _mediator.Send(request);

            return Created(string.Empty, result);
        }

        [AllowAnonymous]
        [HttpPost("SignInCustomer", Name = "SignInCustomer")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<IActionResult> SignInCustomer([FromBody] SignInCustomerRequest request)
        {
            var result = await _mediator.Send(request);

            return Ok(result);
        }

        [HttpPost("SignOutCustomer", Name = "SignOutCustomer")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> SignOutCustomer()
        {
            await _mediator.Send(new SignOutCustomerRequest());

            return NoContent();
        }
    }
}
