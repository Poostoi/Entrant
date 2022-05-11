using System;
using System.Collections.Generic;
using System.Linq;
using Enrollee.Domain.Models;

namespace Enrollee.Infrastructure.Provider;

internal sealed class EntityProvider
{
    private readonly Type[] _modelTypes;

    public EntityProvider()
    {
        var domainAssembly = typeof(IEntity).Assembly;

        _modelTypes = domainAssembly.GetExportedTypes()
            .Where(x => !x.IsAbstract && !x.IsInterface && x.GetInterface(nameof(IEntity)) is not null)
            .ToArray();
    }

    public IEnumerable<Type> GetModels()
    {
        return _modelTypes;
    }
}
