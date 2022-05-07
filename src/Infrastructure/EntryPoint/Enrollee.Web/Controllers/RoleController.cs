using Enrollee.Application.Entities.User;
using Enrollee.Application.Services.User;
using Microsoft.AspNetCore.Mvc;

namespace Enrollee.Web.Controllers;

public class RoleController : ApiBaseController
{
    private readonly IAddRoleService _addRoleService;


    public RoleController(IAddRoleService addRoleService)
    {
        ArgumentNullException.ThrowIfNull(addRoleService);

        _addRoleService = addRoleService;
    }

    [HttpPost("AddRole")]
    public async Task<IActionResult> Registration([FromBody] RoleCommand command,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(command);

        var name = await _addRoleService.HandleAsync(command, cancellationToken).ConfigureAwait(false);
        return Ok(name);
    }
}