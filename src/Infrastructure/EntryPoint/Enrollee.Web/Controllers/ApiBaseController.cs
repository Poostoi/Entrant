using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;

namespace Enrollee.Web.Controllers;

[ApiController]
[Produces(MediaTypeNames.Application.Json)]
[Route("api/[controller]")]
public abstract class ApiBaseController : ControllerBase
{
}
