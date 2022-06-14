using System.Threading;
using System.Threading.Tasks;

namespace Enrollee.Application.Services.User;

public interface IAccountProvider
{
    
    Task<Domain.Models.User.Account?> FindAsync(string login, CancellationToken cancellationToken);

    Task AddAsync(Domain.Models.User.Account account, CancellationToken cancellationToken);
}
