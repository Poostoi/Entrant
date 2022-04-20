using Enrollee.Application.Entities.User;
using Enrollee.Application.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace Enrollee.Web.Controllers;

public class UserController : ApiBaseController
{
    private readonly IRegistrationService _registrationService;

    private readonly ILoginService _loginService;

    public UserController(IRegistrationService registrationService, ILoginService loginService)
    {
        ArgumentNullException.ThrowIfNull(registrationService);
        
        ArgumentNullException.ThrowIfNull(loginService);

        _registrationService = registrationService;

        _loginService = loginService;

    }

    [HttpPost("Registration")]
    public async Task<IActionResult> Registration([FromBody] RegistrationCommand command, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);

        var usrId = await _registrationService.HandleAsync(command, cancellationToken).ConfigureAwait(false);
        return Ok(new { UserId = usrId});
    }

    [HttpGet("Login")]
    public async Task<IActionResult> Login([FromBody] LoginCommand command, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);

        var usrId = await _registrationService.HandleAsync(command, cancellationToken).ConfigureAwait(false);
        return Ok(new { UserId = usrId});
    }

}
