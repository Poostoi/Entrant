using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;

namespace Enrollee.Web.Controllers;

[ApiController]
[Produces(MediaTypeNames.Application.Json)]
[Route("api/[controller]")]
[EnableCors("ReactPolicy")]
public abstract class ApiBaseController : ControllerBase
{
}
