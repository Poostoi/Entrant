using System.Threading;
using System.Threading.Tasks;
using Enrollee.Application.Services.User;
using Enrollee.Domain.Models;
using Enrollee.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;


namespace Enrollee.Infrastructure.Provider;

internal class RoleProvider : IRoleProvider
{
    private readonly ServerDbContext _dbContext;

    public RoleProvider(ServerDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Role?> FindAsync(string name, CancellationToken cancellationToken)
    {
        return await _dbContext.Set<Role>()
            .AsNoTracking()
            .SingleOrDefaultAsync(role => role.Name == name, cancellationToken)
            .ConfigureAwait(false);
    }


    public async Task AddAsync(Role role, CancellationToken cancellationToken)
    {
        _dbContext.Add(role);
        await _dbContext.SaveChangesAsync(cancellationToken).ConfigureAwait(false);
    }
}
