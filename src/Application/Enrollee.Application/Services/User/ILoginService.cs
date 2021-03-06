using System.Threading;
using System.Threading.Tasks;
using Enrollee.Application.Entities.User;

namespace Enrollee.Application.Services.User;

public interface ILoginService
{
    Task<Token> HandleAsync(LoginCommand command, CancellationToken cancellationToken);
}
