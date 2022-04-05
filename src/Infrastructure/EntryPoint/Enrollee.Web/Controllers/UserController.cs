using Enrollee.Application.Entities.User;
using Enrollee.Application.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace Enrollee.Web.Controllers;

public class UserController : ApiBaseController
{
    private readonly IRegistrationService _registrationService;

    public UserController(IRegistrationService registrationService)
    {
        ArgumentNullException.ThrowIfNull(registrationService);

        _registrationService = registrationService;
    }

    [HttpPost("Registration")]
    public async Task<IActionResult> Registration([FromBody] RegistrationCommand command, CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);

        var usrId = await _registrationService.HandleAsync(command, cancellationToken).ConfigureAwait(false);
        return Ok(new { UserId = usrId});
    }
}
