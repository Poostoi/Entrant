using System.Threading;
using System.Threading.Tasks;
using Enrollee.Application.Services.User;
using Enrollee.Domain.Models;
using Enrollee.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;


namespace Enrollee.Infrastructure.Provider;

internal class AccountProvider : IAccountProvider
{
    private readonly ServerDbContext _dbContext;

    public AccountProvider(ServerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Account?> FindAsync(string login, CancellationToken cancellationToken)
    {
        return await _dbContext.Set<Account>()
            .AsNoTracking()
            .SingleOrDefaultAsync(user => user.Login == login, cancellationToken)
            .ConfigureAwait(false);
    }


    public async Task AddAsync(Account account, CancellationToken cancellationToken)
    {
        _dbContext.Add(account);
        await _dbContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
    }
}
