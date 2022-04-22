using System;
using System.Threading;
using System.Threading.Tasks;
using Enrollee.Application.Entities.User;
using Enrollee.Domain.Models;

namespace Enrollee.Application.Services.User;

public interface ILoginService
{
    Task<Tokens> HandleAsync(RegistrationCommand command, CancellationToken cancellationToken);
}
