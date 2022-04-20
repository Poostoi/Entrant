using System.Threading;
using System.Threading.Tasks;

namespace Enrollee.Application.Services.User;

public interface IUserProvider
{
    
    Task<Domain.Models.User?> FindAsync(string login, string password, CancellationToken cancellationToken);
    Task<Domain.Models.User?> FindAsync(string login, CancellationToken cancellationToken);


    Task AddAsync(Domain.Models.User user, CancellationToken cancellationToken);
}
