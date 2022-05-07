using System.Threading;
using System.Threading.Tasks;
using Enrollee.Application.Entities.User;

namespace Enrollee.Application.Services.User;

public interface IAddRoleService
{
    Task<string> HandleAsync(RoleCommand command, CancellationToken cancellationToken);
}