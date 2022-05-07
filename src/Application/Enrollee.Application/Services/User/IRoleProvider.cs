using System.Threading;
using System.Threading.Tasks;

namespace Enrollee.Application.Services.User;

public interface IRoleProvider
{
    
    Task<Domain.Models.Role?> FindAsync(string name, CancellationToken cancellationToken);

    Task AddAsync(Domain.Models.Role role, CancellationToken cancellationToken);
}
