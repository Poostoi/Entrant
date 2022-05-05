using System.Threading;
using System.Threading.Tasks;
using Enrollee.Application.Entities.User;
using Enrollee.Application;

namespace Enrollee.Application.Services.User;

public interface IRegistrationService
{
    Task<Token> HandleAsync(RegistrationCommand command, CancellationToken cancellationToken);
}
