using System;
using System.Threading;
using System.Threading.Tasks;
using Enrollee.Application.Entities.User;

namespace Enrollee.Application.Services.User;

public interface IRegistrationService
{
    Task<Guid> HandleAsync(RegistrationCommand command, CancellationToken cancellationToken);
}
